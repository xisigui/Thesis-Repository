using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject optionScreen;
    public string firstlevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(firstlevel);
    }
    public void OpenOption()
    {
        optionScreen.SetActive(true);
    }

    public void CloseOption()
    {
        optionScreen.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
