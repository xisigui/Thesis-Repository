using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public GameObject[] questions;
    public GameObject QuestionPanel;
    //public GameObject AreaToUnlock;
    public GameObject AttemptIndicator;

    public GameObject soundObjectCorrect;
    public GameObject soundObjectWrong;
    private AudioClip clip;
    private AudioClip Clip;

    public GameObject finishedPanel;
    public GameObject gamePanel;

    
    public Quest quest;
    
    public int currentLevel;
    [SerializeField]
    int Attempt = 3;

    public Image[] hearts;

    void Start(){
         clip = soundObjectCorrect.GetComponent<AudioSource>().clip;
         Clip = soundObjectWrong.GetComponent<AudioSource>().clip;
    }
    void Update()
    {
        if(currentLevel == 9){
            finishedPanel.SetActive(true);
            quest.FinishQuest();
        }
    }

    public void correctAnswer()
    {
        if(currentLevel + 1 != questions.Length)
        {
            questions[currentLevel].SetActive(false);
            currentLevel++;
            questions[currentLevel].SetActive(true);
            soundObjectCorrect.GetComponent<AudioSource>().PlayOneShot(clip);
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
            if (i >= Attempt){
                hearts[i].enabled = false;
                soundObjectWrong.GetComponent<AudioSource>().PlayOneShot(Clip);
            }
            else{
                 hearts[i].enabled = true;
            }
        }
    }

    public void ResetQuestions()
    {
        currentLevel = 0;
        Attempt = 3;

        questions[currentLevel].SetActive(false);
        questions[currentLevel].SetActive(true);
    }

    public void ContinueButton(){
        gamePanel.SetActive(false);
    }
}
