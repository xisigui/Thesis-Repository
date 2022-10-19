using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEvents : MonoBehaviour
{       
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

	public void LoadFindLetterScene ()
	{
		StartCoroutine(SceneLoader.LoadSceneAsync ("DifficultyMenu"));
	} 

	public void LoadEasyDifficultyScene()
	{
		StartCoroutine(SceneLoader.LoadSceneAsync ("Easy"));
	}

	public void LoadNormalDifficultyScene()
	{
		StartCoroutine(SceneLoader.LoadSceneAsync ("Normal"));
	}

	public void LoadHardDifficultyScene()
	{
		StartCoroutine(SceneLoader.LoadSceneAsync ("Hard"));
	}
	
}
