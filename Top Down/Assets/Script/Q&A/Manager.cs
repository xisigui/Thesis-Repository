using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] questions;
    public GameObject QuestionPanel;
    public GameObject AreaToUnlock;
    public GameObject AttemptIndicator;
    
    public int currentLevel;
    [SerializeField]
    int Attempt = 3;

    public Image[] hearts;
    void Update()
    {
        if(currentLevel == 9){
            AreaToUnlock.SetActive(false);
        }
    }

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
    public void WrongAnswer()
    {
        Attempt--;
        
        if(Attempt == 0)
        {
            questions[currentLevel].SetActive(false);
            QuestionPanel.SetActive(false);
            AttemptIndicator.SetActive(false);
            questions[currentLevel].SetActive(false);  
            currentLevel = 0;
            questions[currentLevel].SetActive(true);
            Attempt = 3;
        }

        for(int i = 0; i < hearts.Length;i++)
        {
            if (i >= Attempt)
                hearts[i].enabled = false;
            else
                hearts[i].enabled = true;
        }
    }

    public void ResetQuestions()
    {
        currentLevel = 0;
        Attempt = 3;

        questions[currentLevel].SetActive(false);
        questions[currentLevel].SetActive(true);
    }
}
