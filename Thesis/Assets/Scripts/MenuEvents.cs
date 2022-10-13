using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEvents : MonoBehaviour
{   
    public void LoadFindLetterScene ()
	{
		StartCoroutine(SceneLoader.LoadSceneAsync ("FindTheLetter"));
	} 
    public void LoadTracingLetterScene()
	{
		StartCoroutine(SceneLoader.LoadSceneAsync ("Main"));
	}
    public void LoadImagePuzzleScene()
	{
		StartCoroutine(SceneLoader.LoadSceneAsync ("Image Puzzle"));
	}

	 public void LoadColorQuizScene()
	{
		StartCoroutine(SceneLoader.LoadSceneAsync ("Persistent"));
	}
    
	 public void LoadMatchandTypeScene()
	{
		StartCoroutine(SceneLoader.LoadSceneAsync ("DragAndDrop"));
	}

	public void LoadMainMenuScene()
	{
		StartCoroutine(SceneLoader.LoadSceneAsync ("ScrollMainMenu"));
	}
	
}
