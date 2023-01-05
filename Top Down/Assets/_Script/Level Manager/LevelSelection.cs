using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public Button[] lvlButton;
    //public Interactable interactable;
    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("LevelAt", 2);

        for (int i = 0; i < lvlButton.Length; i++)
        {
            if(i + 2 > levelAt){
                lvlButton[i].interactable = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
