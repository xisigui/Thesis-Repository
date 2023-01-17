using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlayer : MonoBehaviour
{
    public GameObject loadingScreen;
    public UnityEngine.Video.VideoPlayer vidPlayer;
    // Start is called before the first frame update
    void Start()
    {
        // vidPlayer.loopPointReached += loadVerbScene;
        vidPlayer.loopPointReached += loadVerbScene;
    }

    // Update is called once per frame
    void loadVerbScene(UnityEngine.Video.VideoPlayer vp)
    {
        StartCoroutine(LoadLevelAsync("VerbLevel"));
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
}
