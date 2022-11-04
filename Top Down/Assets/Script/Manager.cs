using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] levels;
    
    int currentLevel;

    public void CorrectAnswer(){
        if(currentLevel + 1 != levels.Length){
            levels[currentLevel].SetActive(false);

            currentLevel++;
            levels[currentLevel].SetActive(true);
        }
    }

}
