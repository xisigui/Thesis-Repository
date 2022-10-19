using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private AudioSource source; 
    [SerializeField] private AudioClip pickUpsound, dropSound;
    private bool isDragging,isPlaced;
    private Vector2 offset,originalPos;
    private PuzzleSlot _slot;

    public void Init(PuzzleSlot slot)
    {
        _renderer.sprite = slot.Renderer.sprite;
        _slot = slot;
    }
    
    void Awake(){
        originalPos = transform.position;
    }

    void Update(){
        if(isPlaced) return;
        if(!isDragging) return;

        var mousePosition = GetMousePos();
    
        transform.position = mousePosition - offset;
    }
    void OnMouseDown(){
        isDragging = true;
        source.PlayOneShot(pickUpsound);

        offset = GetMousePos() - (Vector2)transform.position;
    }

    void OnMouseUp(){
        if(Vector2.Distance(transform.position,_slot.transform.position) > 3){
            transform.position = _slot.transform.position;
            _slot.Placed();
            isPlaced = true;
        }
        else
        {
            transform.position = originalPos;
            source.PlayOneShot(dropSound);
            isDragging = false;
        }
        transform.position = originalPos;
        isDragging = false;
        source.PlayOneShot(dropSound);
    }

    Vector2 GetMousePos(){
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
