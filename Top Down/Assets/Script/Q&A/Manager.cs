using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] questions;
    public GameObject QuestionPanel;
    int currentLevel;

    void Start()
    {

    }

    void Update()
    {
        
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
}
