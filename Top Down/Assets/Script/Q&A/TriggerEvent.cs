using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public GameObject QuestionPanel;
    public GameObject interactText;
    public GameObject AttemptIndicator;
    public Manager manager;

    bool isInside; 

    void Update()
    {
        if(isInside)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(manager.currentLevel != 9){
                    manager.ResetQuestions();
                }
                QuestionPanel.SetActive(true);
                AttemptIndicator.SetActive(true);
            }
        }
        if(manager.currentLevel == 9)
            manager.AreaToUnlock.SetActive(false);    
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
        AttemptIndicator.SetActive(false);
        isInside = false;
    }
}
