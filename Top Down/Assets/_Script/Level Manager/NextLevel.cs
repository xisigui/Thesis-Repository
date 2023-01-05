using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int NextSceneLoad;
    // Start is called before the first frame update
    public void Nextlevel()
    {
        NextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void ProceedNextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex == 7 ){
            Debug.Log("All level complete");
        }
        SceneManager.LoadScene(NextSceneLoad);

        if(NextSceneLoad > PlayerPrefs.GetInt("LevelAt")){
            PlayerPrefs.SetInt("LevelAt",NextSceneLoad);
        }
    }
}
