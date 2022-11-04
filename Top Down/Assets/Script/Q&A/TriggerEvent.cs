using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public GameObject QuestionPanel;

    void OnTriggerEnter2D(Collider2D collider)
    {
        QuestionPanel.SetActive(true);
    }
}
