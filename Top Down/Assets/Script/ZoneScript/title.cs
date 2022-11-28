using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;

public class title : MonoBehaviour
{
    public GameObject TitleCanvas;
    public TMP_Text TitleText;
    public string Text;
    public Image screenDim;
    public float duration; 
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        StartCoroutine(LateCall(duration));
        var tempColor = screenDim.color;
        tempColor.a = 0.6f;
        screenDim.color = tempColor;
    }

    IEnumerator LateCall(float seconds)
    {
        TitleCanvas.SetActive(true);
        TitleText.text = Text; 
        LeanTween.alpha(screenDim.rectTransform, 0f, duration).setEaseInOutExpo().setOnComplete(Hide);
        yield return new WaitForSeconds(seconds);
    }

    void Hide()
    {
        TitleCanvas.SetActive(false);
    }
}
