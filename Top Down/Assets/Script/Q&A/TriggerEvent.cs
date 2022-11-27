using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public GameObject QuestionPanel;
    public GameObject interactText;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public Manager manager;

    private bool isInside; 

    void Start(){

    }
    void Update()
    {
        if(isInside)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(manager.Score != 10){
                    manager.ResetQuestions();
                }
                QuestionPanel.SetActive(true);
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
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
        heart1.SetActive(false);
        heart2.SetActive(false);
        heart3.SetActive(false);
        isInside = false;
        if(manager.Score == 10)
        manager.AreaToUnlock.SetActive(false);
    }
}
