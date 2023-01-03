using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroDialogueTrigger : MonoBehaviour
{
    private bool istriggered = false;
    public GameObject disableObject; 
    public DialogueTrigger trigger;
    
    private void OnTriggerEnter2D(Collider2D collision){
        if(istriggered == false){
            if(collision.gameObject.CompareTag("Player") == true){
                trigger.StartDialogue();
            }
            istriggered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        istriggered = false;
        disableObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player") == true)
        trigger.StartDialogue();
    }
}