using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveManager : MonoBehaviour
{
    public GameObject[] objectives;
    public Quest quest;
    public Color finished;

    void Update()
    {
        for (int i = 0; i < objectives.Length; i++)
        {
            if(objectives[i].GetComponent<Quest>().currentColor == finished)
                {
                   Debug.Log(objectives[i].name+ " is completed");              
                } 
        }
    }   
}
