using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockLevel : MonoBehaviour
{
    public Manager quizmanager;
    int holder;
    public void Start()
    {
    //holder = quizmanager.currectLevelValueHolder;
    }
    void Update(){
        IsCompleted();
    }
    void IsCompleted(){
        if(holder == quizmanager.questions.Length){
            quizmanager.AreaToUnlock.SetActive(false);
        }
    }
}
