using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public Button[] lvlButton;

    //public Interactable interactable;
    // Start is called before the first frame update
    void Start()
    {
        // int levelAt = PlayerPrefs.GetInt("LevelAt", 2);

        // for (int i = 0; i < lvlButton.Length; i++)
        // {
        //     if(i + 2 > levelAt){
        //         lvlButton[i].interactable = false;
        //     }
        // }
    }

    public void loadLevelNoun(){
        SceneManager.LoadScene("NounLevel");
    }

    public void loadLevelVerb(){
        SceneManager.LoadScene("VerbLevel");
    }
}
