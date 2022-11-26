using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] questions;
    public GameObject QuestionPanel;
    int currentLevel;

    public int wrongAns;

    public void correctAnswer()
    {
        if(currentLevel + 1 != questions.Length)
        {
            questions[currentLevel].SetActive(false);
            currentLevel++;
            questions[currentLevel].SetActive(true);
        }
        else
        {            
            questions[currentLevel].SetActive(false);
            QuestionPanel.SetActive(false);
        }
    }

    public void WrongAnswer(){
        wrongAns++;
        
        if(wrongAns != 3){
            questions[currentLevel].SetActive(false);
            currentLevel++;
            questions[currentLevel].SetActive(true);
        } else {
            questions[currentLevel].SetActive(false);
            QuestionPanel.SetActive(false);
            questions[currentLevel].SetActive(false);
            currentLevel = 0;
            questions[currentLevel].SetActive(true);
            wrongAns = 0;
        }
    }
}
