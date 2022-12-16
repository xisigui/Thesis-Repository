using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableWord : MonoBehaviour, IPointerClickHandler
{
    string _randomWord;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log($"Clicked on: {_randomWord}");        
    }

    public void SetLetter(string word)
    {
        enabled = true;
        _randomWord = word;        
        GetComponent<TMP_Text>().text = _randomWord;
    }
}
