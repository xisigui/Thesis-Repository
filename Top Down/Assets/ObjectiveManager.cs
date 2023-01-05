using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveManager : MonoBehaviour
{
    public GameObject[] objectives;
    public Quest quest;

    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            Button button = child.GetComponent<Button>();
            if (button != null)
            {
                Debug.Log("Button color: " + quest.currentColor);
            }
        }
    }

    void Update()
    {
        
    }
}
