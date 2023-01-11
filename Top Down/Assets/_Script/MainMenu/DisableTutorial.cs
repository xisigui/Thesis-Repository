using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTutorial : MonoBehaviour
{
    public GameObject disableObject;    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DisableObject(){
        disableObject.SetActive(false);
    }


}
