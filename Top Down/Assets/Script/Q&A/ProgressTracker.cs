using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    public GameObject[] Quizzes;

    public void CheckLevels()
    {
        for(int i = 0;i < Quizzes.Length; i++)
        {
            if(Quizzes[i].GetComponent<Manager>().currentLevel != 9)
                Debug.Log(Quizzes[i].name + " is not complete yet"); 
            else
                Debug.Log(Quizzes[i].name + " is complete"); 
        }
    }

    public void CompleteAll()
    {
        for(int i = 0;i < Quizzes.Length; i++)
        {
            if(Quizzes[i].GetComponent<Manager>().currentLevel != 9)
                Quizzes[i].GetComponent<Manager>().currentLevel = 9;
        }
        Debug.Log("All Levels are completed");
    }
}
