using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveManager : MonoBehaviour
{
    public GameObject[] objectives;
    public GameObject[] tutorial;

    public GameObject Popup;

    public void CheckForIncomplete()
    {
        int incomplete = 0;
        for (int i = 0; i < objectives.Length; i++)
        {
            if(!objectives[i].GetComponent<Quest>().isFinished)
            {
                Debug.Log(objectives[i].name + " is not done"); 
                incomplete++;            
            } 
        }
        if(incomplete <= 0)
        {
            Dialog.SetActive(true);
        }

    }
}
