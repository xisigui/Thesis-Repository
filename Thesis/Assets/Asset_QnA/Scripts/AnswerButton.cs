using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerButton : MonoBehaviour
{
    public TMP_Text answerText;

    private AnswerData answerData;
    private GameController gameController;

    // Use this for initialization
    void Start () 
    {
        gameController = FindObjectOfType<GameController> ();
    }

    public void Setup(AnswerData data)
    {
        answerData = data;
        answerText.text = answerData.answerText;
    }


    public void HandleClick()
    {
        gameController.AnswerButtonClicked (answerData.isCorrect);
    }
}
