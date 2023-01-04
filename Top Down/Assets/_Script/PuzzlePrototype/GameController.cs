using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject soundObjectCorrect;
    public GameObject soundObjectWrong;
    private AudioClip clip;
    private AudioClip Clip;
    public GameObject continueButton;
    public GameObject gameCanvas;
    public Quest quest;

    int _correctAnswers = 3;
    int _correctClicks;
    int _wrongClicks;
    string[] nounDictionary = { "Book", "Student", "Teacher", "Year", "Friend", "People" };
    string[] fillDictionary = { "Eat", "Play", "Grab", "Replace", "Jump", "Roll" };

    public Image[] pictures;

    void Start(){
        clip = soundObjectCorrect.GetComponent<AudioSource>().clip;
        Clip = soundObjectWrong.GetComponent<AudioSource>().clip;
        continueButton.transform.localScale = Vector3.zero;
    }

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
            wordList.Add(fillDictionary[i]); 

        wordList = wordList.OrderBy(t => UnityEngine.Random.Range(0, 10000)).ToList();

        for (int i = 0; i < clickables.Length; i++)
        {
            clickables[i].SetLetter(wordList[i]);
        }   
        FindObjectOfType<RemainingCounterText>().SetRemaining(_correctAnswers);                     
    }

    public void checkWord(string word)
    {        
        if(nounDictionary.Contains(word))
        {            
            foreach(Image pic in pictures)
            {
                if(pic.name == word)
                {
                    soundObjectCorrect.GetComponent<AudioSource>().PlayOneShot(clip);
                    pic.GetComponent<Image>().color = new Color32(105,105,105,100);
                    break;
                }
            }
            _correctClicks++;
            FindObjectOfType<CorrectCounterText>().SetCorrectCount(_correctClicks);
            ClickableWord.isCorrect = true;
        }else
        {
            _wrongClicks++;
            soundObjectWrong.GetComponent<AudioSource>().PlayOneShot(Clip);
            ClickableWord.isCorrect = false;
        }

        if (_correctClicks >= _correctAnswers)
        {
            continueButton.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
            Debug.Log("All Noun has been found");
            _correctClicks = 0;
            quest.FinishQuest();
        }
    }
    public void ContinueButton(){
        gameCanvas.SetActive(false);
    }
}
