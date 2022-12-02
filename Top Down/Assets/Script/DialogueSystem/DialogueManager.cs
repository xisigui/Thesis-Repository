using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Image actorImage;
    public TMP_Text actorName;
    public TMP_Text messageText;
    public RectTransform backgroundBox;

    Message[] currentMessages;
    Actor[] currentActors;

    int activeMessage = 0;
    public static bool isActive = false;

    public void OpenDialogue(Message[] messages, Actor[] actors){
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;
        Debug.Log("Started Conversation! loaded messages:" + messages.Length);
        DisplayMessage();
        backgroundBox.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
        FindObjectOfType<MusicManager>().StopPlaying("Main Music");
        FindObjectOfType<MusicManager>().Play("Dialog Music");
    }

    void DisplayMessage(){        
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        Actor actorToDisplay = currentActors[messageToDisplay.actorid];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;

        AnimateTextColor();
    }

    public void NextMessage(){
        activeMessage++;
        if(activeMessage < currentMessages.Length){
            DisplayMessage();
        } else {
            Debug.Log("Conversation Ended");
            backgroundBox.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo();
            isActive = false;                  
            FindObjectOfType<MusicManager>().StopPlaying("Dialog Music");   
            FindObjectOfType<MusicManager>().Play("Main Music");  
        } 
    }


    void AnimateTextColor(){
        LeanTween.textAlpha(messageText.rectTransform, 0, 0);
        LeanTween.textAlpha(messageText.rectTransform, 1, 0.5f);
    }

    void Start(){
        backgroundBox.transform.localScale = Vector3.zero;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isActive == true)
            NextMessage();
    }
}
