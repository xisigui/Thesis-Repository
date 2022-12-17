using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableWord : MonoBehaviour, IPointerClickHandler
{
    string _randomWord;
    
    public void OnPointerClick(PointerEventData eventData)
    { 
        FindObjectOfType<GameController>().checkWord(_randomWord);   
        enabled = false;         
    }

    public void SetLetter(string word)
    {
        enabled = true;
        _randomWord = word;        
        GetComponent<TMP_Text>().text = _randomWord;
    }
}
