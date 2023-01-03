using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;
    public GameObject NPC;

    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if(i == popUpIndex){
                popUps[i].SetActive(true);
            } else {
                popUps[i].SetActive(false);
            }
        }
        
        if(popUpIndex == 0)
        {
            if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W))
            {
               Invoke("PopUpIncrementDelay", 5);
            }
        } else if (popUpIndex == 1) 
        {
            NPC.SetActive(true);
            Invoke("PopUpIncrementDelay", 5);
            //Other Mechanic tutorial 
        }
    }

    public void PopUpIncrementDelay(){
        popUpIndex++;
    }
    
    
}
