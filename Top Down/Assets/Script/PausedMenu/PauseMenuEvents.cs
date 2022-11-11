using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuEvents : MonoBehaviour
{
    public GameObject PausedScreen;
    public GameObject MenuUI;
    public GameObject SettingsUI;

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PausedScreen.SetActive(false);
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

    public void ResetLevel()
    {

    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PausedScreen.SetActive(true);
    }

    public void QuitLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
