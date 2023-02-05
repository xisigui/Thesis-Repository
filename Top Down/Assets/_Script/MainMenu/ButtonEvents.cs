using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    public GameObject loadingScreen;
    public GameObject creditPanel;
    public void LoadGameScene(string levelToLoad)
    {        
        StartCoroutine(LoadLevelAsync(levelToLoad));
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<MusicManager>().StopPlaying("Dialog Music");   
        FindObjectOfType<MusicManager>().Pause("Main Music");   
        FindObjectOfType<MusicManager>().Play("Intro Music");
    }    

    public void Quit()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    IEnumerator LoadLevelAsync(string levelToLoad)
    {
        loadingScreen.SetActive(true);
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);
        while(!loadOperation.isDone)
        {
            yield return null;
        }
    }

    public void OpenCredits(){
        creditPanel.SetActive(true);
    }

    public void CloseCredits(){
        creditPanel.SetActive(false);
    }
}
