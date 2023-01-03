using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    /*Do Player Related Things Here
        *Script Interactions
        *Quest or Tracking Things
    */
    public GameObject interactNotificationIcon;

    public void NotifyPlayer(){
        interactNotificationIcon.SetActive(true);
    }

    public void DenotifyPlayer(){
        interactNotificationIcon.SetActive(false);
    }
}
