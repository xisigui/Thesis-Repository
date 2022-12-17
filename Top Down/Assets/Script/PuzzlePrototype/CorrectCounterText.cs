using TMPro;
using UnityEngine;

public class CorrectCounterText : MonoBehaviour
{
    internal void SetCorrectCount(int correct)
    {
        GetComponent<TMP_Text>().text = correct.ToString();
    }
}