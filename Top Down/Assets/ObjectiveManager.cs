using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveManager : MonoBehaviour
{
    public GameObject[] objectives;

    void Update()
    {
        foreach (GameObject i in objectives)
        {
            if(i.GetComponent<Quest>().isFinished)
            {
                Debug.Log(i.name + " is finished");
            }     
        }
    }   
}
