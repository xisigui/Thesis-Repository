using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlayer : MonoBehaviour
{
    public GameObject loadingScreen;
    public UnityEngine.Video.VideoPlayer vidPlayer;
    public string SceneToLoad;

    public GameObject skipbutton;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("showSkipButton", 30);
        vidPlayer.loopPointReached += loadScene;
    }

    // Update is called once per frame
    void loadScene(UnityEngine.Video.VideoPlayer vp)
    {
        StartCoroutine(LoadLevelAsync(SceneToLoad));
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

    void showSkipButton(){
        skipbutton.SetActive(true);
    }

    public void skipCutscene(){
        SceneManager.LoadScene(SceneToLoad);
    }
}
