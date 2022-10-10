using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScreenController : MonoBehaviour
{
   
   public void StartGame ()
   {
        SceneManager.LoadScene("QnAGame");
   }
}
