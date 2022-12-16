using TMPro;
using UnityEngine;

public class DisplayWord : MonoBehaviour
{
    internal void SetWord(string word)
    {
        GetComponent<TMP_Text>().text = word;
    }
}