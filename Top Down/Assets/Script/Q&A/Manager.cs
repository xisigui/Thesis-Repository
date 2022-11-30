using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] questions;
    public GameObject QuestionPanel;
    public GameObject AreaToUnlock;
    
    public Quest quest;
    QuestGoal goal;

    public int currentLevel;
    [SerializeField]
    public int Score = 1;
    int Attempt = 3;

    void Update()
    {
        if(Score == 10){
            if(quest.isActive)
            {
                quest.goal.QuizTaken(); 
                if(quest.goal.IsReached())
                {
                    Debug.Log("ALL Quiz is finished");
                    quest.Complete();
                }
            }
            AreaToUnlock.SetActive(false);
        }
    }
    void Start()
    {
        if(Score != 10)
            ResetQuestions();
    }
    public void correctAnswer()
    {
        Score++;
        if(currentLevel + 1 != questions.Length)
        {
            questions[currentLevel].SetActive(false);
            currentLevel++;
            questions[currentLevel].SetActive(true);
            Debug.Log("Score" + Score);
        }
        else
        {            
            questions[currentLevel].SetActive(false);
            QuestionPanel.SetActive(false);
            Debug.Log("Score" + Score);          
        }
    }
    public Image[] images;
    public void WrongAnswer()
    {
        Attempt--;
        
        if(Attempt == 0)
        {
            questions[currentLevel].SetActive(false);
            QuestionPanel.SetActive(false);
            questions[currentLevel].SetActive(false);  
            currentLevel = 0;
            questions[currentLevel].SetActive(true);
            Attempt = 3;
        }

        for(int i = 0; i < images.Length;i++)
        {
            // Hide all images superior to the newHealth
            if (i >= Attempt)
                images[i].enabled = false;
            else
                images[i].enabled = true;
        }
    }

    public void ResetQuestions()
    {
        currentLevel = 0;
        Attempt = 3;
        Score = 0;

        questions[currentLevel].SetActive(false);
        questions[currentLevel].SetActive(true);
    }
}
