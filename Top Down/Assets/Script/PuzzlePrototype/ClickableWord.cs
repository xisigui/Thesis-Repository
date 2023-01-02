using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableWord : MonoBehaviour, IPointerClickHandler
{
    string _randomWord;
    public static bool isCorrect;
    
    public void OnPointerClick(PointerEventData eventData)
    { 
        FindObjectOfType<GameController>().checkWord(_randomWord);
        if(isCorrect)
            GetComponent<TMP_Text>().color = Color.green;
        else
            GetComponent<TMP_Text>().color = Color.gray;

        enabled = false;                
    }

    public void SetLetter(string word)
    {
        enabled = true;
        _randomWord = word;        
        GetComponent<TMP_Text>().text = _randomWord;
    }
}
