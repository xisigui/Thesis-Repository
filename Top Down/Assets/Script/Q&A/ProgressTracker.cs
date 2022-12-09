using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgressTracker : MonoBehaviour
{
    public GameObject[] Quizzes;


    public void Update()
    {
        int numberOfFinishedAltar = 0;           
            for(int i = 0;i < Quizzes.Length; i++)
            {
                if(Quizzes[i].GetComponent<Manager>().currentLevel != 9)
                {
                    Debug.Log(Quizzes[i].name + " is not complete yet");                     
                } 
                else
                {
                    Debug.Log(Quizzes[i].name + " is complete");
                    numberOfFinishedAltar++;                    
                }     
            }
            if( numberOfFinishedAltar == 8)
            {
                SceneManager.LoadScene(3); 
            }       
    }

    public void CompleteAll()
    {
        for(int i = 0;i < Quizzes.Length; i++)
        {
            if(Quizzes[i].GetComponent<Manager>().currentLevel != 9)
            {
                Quizzes[i].GetComponent<Manager>().currentLevel = 9;
                // SceneManager.LoadScene(3); 
            }    
        }
        Debug.Log("All Levels are completed");
    }
}
