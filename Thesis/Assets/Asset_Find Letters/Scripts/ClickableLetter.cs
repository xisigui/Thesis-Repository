using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ClickableLetter : MonoBehaviour, IPointerClickHandler
{
    char _randomLetter;
    bool _upperCase;
    public void OnPointerClick(PointerEventData eventData)
    {
        // Debug.Log($"Clicked on letter {_randomLetter}");
        if (_randomLetter == GameControll.Instance.Letter)
        {
            GetComponent<TMP_Text>().color = Color.green;
            enabled = false;
            GameControll.Instance.HandleCorrectLetterClick(_upperCase);
        }else
        {
            GetComponent<TMP_Text>().color = Color.red;
            enabled = false;
            GameControll.Instance.HandleWrongClick(_upperCase);
        }
    }

    public void SetLetter(char letter)
    {
        enabled = true;
        GetComponent<TMP_Text>().color = Color.black;
        _randomLetter = letter;

        if (Random.Range(0, 100) > 50)
        {
            _upperCase = false;
            GetComponent<TMP_Text>().text = _randomLetter.ToString();
        }
        else
        {
            _upperCase = true;
            GetComponent<TMP_Text>().text = _randomLetter.ToString().ToUpper();
        }
    }
}
