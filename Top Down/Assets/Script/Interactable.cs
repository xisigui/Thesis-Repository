using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactkey;
    public UnityEvent interactAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
            Debug.Log("In Ranged");
        }
    }

     private void OnTriggerExit2D(Collider2D collider){
        if(collider.gameObject.CompareTag("Player")){
            isInRange = false;
            Debug.Log("Not in Ranged");
        }
    }
}
