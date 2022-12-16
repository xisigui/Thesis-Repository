using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    string Word = "Google";
    int _correctAnswers = 5;
    string[] nounDictionary = { "Family", "People", "Friend", "Year", "Teacher", "Student" };

    void OnEnable()
    {
        GenerateBoard();
    }
    void GenerateBoard()
    {
        var clickables = FindObjectsOfType<ClickableWord>();

        for (int i = 0; i < clickables.Length; i++)
            clickables[i].SetLetter(nounDictionary[Random.Range(0,nounDictionary.Length)]);     
    }
}
