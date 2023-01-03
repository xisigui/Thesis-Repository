using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public GameObject[] levelShrines;

    private void Awake(){
        int ReachedLevel = PlayerPrefs.GetInt("ReachedLevel", 1);
        if(PlayerPrefs.GetInt("Level") >= 2)
        {
            ReachedLevel = PlayerPrefs.GetInt("Level");
        }

        levelShrines = new GameObject[transform.childCount];
        for(int i=0; i<levelShrines.Length;i++){
            levelShrines[i] = transform.GetChild(i).GetComponent<GameObject>();
            //levelShrines[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
            if(i+1> ReachedLevel){
                //levelShrines[i]
            }
        }
    }

    public void LoadScene(int level){
        PlayerPrefs.SetInt("Level", level);
        //Application.LoadLevel("Loading");
    }
}
