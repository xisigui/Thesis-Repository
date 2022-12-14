using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectionTrigger : MonoBehaviour
{
    public GameObject interactText;

    bool isInside;

      void Update()
    {
        if(isInside)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //Transition To noun Level Here
            }
        }       
    }

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
}
