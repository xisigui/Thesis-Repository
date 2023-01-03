using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactkey;
    public UnityEvent interactAction;

    void Update()
    {
        if(isInRange){
            if(Input.GetKeyDown(interactkey)){
                interactAction.Invoke();
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.CompareTag("Player")){
            isInRange = true;
            collider.gameObject.GetComponent<PlayerManager>().NotifyPlayer();
            Debug.Log("In Ranged");
        }
    }

     private void OnTriggerExit2D(Collider2D collider){
        if(collider.gameObject.CompareTag("Player")){
            isInRange = false;
            collider.gameObject.GetComponent<PlayerManager>().DenotifyPlayer();
        }
    }
}
