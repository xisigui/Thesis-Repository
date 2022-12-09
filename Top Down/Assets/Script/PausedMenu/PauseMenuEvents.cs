using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuEvents : MonoBehaviour
{
    public GameObject PausedScreen;
    public GameObject MenuUI;
    public GameObject SettingsUI;
    public GameObject QuitGamePopup;

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PausedScreen.SetActive(false);
        FindObjectOfType<MusicManager>().StopPlaying("Dialog Music");
        FindObjectOfType<MusicManager>().Play("Main Music");
    }

    public void OpenSettings()
    {
        SettingsUI.SetActive(true);
        MenuUI.SetActive(false);
    }

    public void CloseSettings()
    {
        SettingsUI.SetActive(false);
        MenuUI.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PausedScreen.SetActive(true);
        FindObjectOfType<MusicManager>().Pause("Main Music");
        FindObjectOfType<MusicManager>().Play("Dialog Music");
    }

    public void QuitLevel()
    {
        Time.timeScale = 1;
        FindObjectOfType<MusicManager>().StopPlaying("Dialog Music");
        FindObjectOfType<MusicManager>().Play("Main Music");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void OpenQuitMessange()
    {
        QuitGamePopup.SetActive(true);
        MenuUI.SetActive(false);
    }
    public void CloseQuitMessange()
    {
        QuitGamePopup.SetActive(false);
        MenuUI.SetActive(true);
    }
}
