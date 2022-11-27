using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] questions;
    public GameObject QuestionPanel;
    public GameObject AreaToUnlock; 
    public int currentLevel;
    [SerializeField]
    private int currectLevelValueHolder;
    public int Score = 1;
    private int wrongAns;

    void Update(){
        if(Score == 10)
            AreaToUnlock.SetActive(false);
    }
    void Start(){
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
            currectLevelValueHolder = currentLevel + 1; 
            QuestionPanel.SetActive(false);
            Debug.Log("holder"+currectLevelValueHolder);
            Debug.Log("Score" + Score);          
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

    public void ResetQuestions(){
            currentLevel = 0;
            wrongAns = 0;
            currectLevelValueHolder = 0;
            Score = 0;

            questions[currentLevel].SetActive(false);
            questions[currentLevel].SetActive(true);
    }
}
