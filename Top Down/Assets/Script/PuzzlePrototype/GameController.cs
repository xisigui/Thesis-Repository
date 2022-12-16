using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    int _correctAnswers = 5;
    int _correctClicks = 0;
    string[] nounDictionary = { "Family", "People", "Friend", "Year", "Teacher", "Student" };
    string[] fillDictionary = { "Blank", "Blank", "Blank", "Blank", "Blank", "Blank" };

    void OnEnable()
    {
        GenerateBoard();
    }
    void GenerateBoard()
    {
        var clickables = FindObjectsOfType<ClickableWord>();
        List<string> wordList = new List<string>();

        for (int i = 0; i < _correctAnswers; i++)
            wordList.Add(nounDictionary[i]);

        //Not final, Only used to populate the wordsList to fill all clickable words.
        for(int i = 0; i < clickables.Length - _correctAnswers; i++)
            wordList.Add(fillDictionary[Random.Range(0, fillDictionary.Length)]); 

        wordList = wordList.OrderBy(t => UnityEngine.Random.Range(0, 10000)).ToList();

        for (int i = 0; i < clickables.Length; i++)
        {
            clickables[i].SetLetter(wordList[i]);
        }   
        FindObjectOfType<RemainingCounterText>().SetRemaining(_correctAnswers);                     
    }

    public void checkWord(string word)
    {
        for (int i = 0;i<nounDictionary.Length ;i++)
        {
            if(word.Equals(nounDictionary[i]))
            {
                _correctClicks++;
                FindObjectOfType<CorrectCounterText>().SetCorrectCount(_correctClicks);
            }                
        }

        if (_correctClicks >= _correctAnswers)
        {
            Debug.Log("All Noun has been found");
            _correctClicks = 0;
        }
        
    }
}
