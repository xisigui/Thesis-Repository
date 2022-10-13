using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSlot : MonoBehaviour
{
    public SpriteRenderer Renderer;
    [SerializeField] AudioSource source;
    //[SerializeField] AudioClip completeClip;

    public void Placed(){
        //source.PlayOneShot(completeClip);
        source.Play();
    }
}
