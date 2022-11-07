using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public GameObject QuestionPanel;
    public GameObject interactText;

    private bool isInside; 

    void Update()
    {
        if(isInside)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                QuestionPanel.SetActive(true);
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
        QuestionPanel.SetActive(false);
        isInside = false;
    }
}
