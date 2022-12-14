using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;
    public GameObject NPC;
    public float waitTime = 2f;

    void Update(){
        for (int i = 0; i < popUps.Length; i++)
        {
            if(i == popUpIndex){
                popUps[i].SetActive(true);
            } else {
                popUps[i].SetActive(false);
            }
        }

        if(popUpIndex == 0){
            if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W)){
                popUpIndex++;
            }
        } else if (popUpIndex == 1) {
            if(waitTime <= 0){
                NPC.SetActive(true);
                popUpIndex++;
            }else {
                waitTime -= Time.deltaTime;
            }
        } else {
            //Other Mechanic tutorial 
        }
    }
    
}
