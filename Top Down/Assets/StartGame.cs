using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject activity;
    public GameObject tutorialButton;
    public GameObject tutorial;
    // Start is called before the first frame update
    public void StartActivity()
    {
        activity.SetActive(true);
    }

    public void CloseActivity()
    {
        activity.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collider){
        if(collider.tag == "Player"){
            activity.SetActive(false);
            tutorialButton.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.tag == "Player"){
            tutorialButton.SetActive(true);
        }
    }

    public void OpenTutorial(){
        tutorial.SetActive(true);
    }


}
