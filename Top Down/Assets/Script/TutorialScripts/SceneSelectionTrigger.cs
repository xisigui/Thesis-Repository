using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectionTrigger : MonoBehaviour
{
    public GameObject interactText;
    public int level;

    bool isInside;

    void OnTriggerEnter2D(Collider2D collider)
    {
        interactText.SetActive(true);
        isInside = true;
    }     

    void OnTriggerExit2D(Collider2D other)
    {        
        interactText.SetActive(false);
        isInside = false;
    }

    public void OpenScene(){
        if(isInside){
            SceneManager.LoadScene(level);
        }
       
    }
}
