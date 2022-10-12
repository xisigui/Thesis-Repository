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
    
}
