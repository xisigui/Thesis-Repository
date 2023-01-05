using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MatchItem : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerEnterHandler, IPointerUpHandler

{
    static MatchItem hoverItem;

    public GameObject linePrefab;

    public string itemName;

    private GameObject line;

    public GameObject soundObjectCorrect;
    public GameObject soundObjectWrong;
    private AudioClip clip;
    private AudioClip Clip;
    
    void Start(){
        clip = soundObjectCorrect.GetComponent<AudioSource>().clip;
        Clip = soundObjectWrong.GetComponent<AudioSource>().clip;
    }


    public void OnPointerDown(PointerEventData eventData){
        line = Instantiate(linePrefab, transform.position, Quaternion.identity, transform.parent.parent);
        UpdateLine(eventData.position);
    }

    public void OnDrag(PointerEventData eventData){
        UpdateLine(eventData.position);
    }

    public void OnPointerUp(PointerEventData eventData){
        if(!this.Equals(hoverItem) && itemName.Equals(hoverItem.itemName)){
            UpdateLine(hoverItem.transform.position);
            MatchLogic.AddPoint();
            soundObjectCorrect.GetComponent<AudioSource>().PlayOneShot(clip);
            Destroy(hoverItem);
            Destroy(this);
        } else {
            soundObjectWrong.GetComponent<AudioSource>().PlayOneShot(Clip);
            Destroy(line);
        }
    }

    public void UpdateLine(Vector3 position){
        Vector3 direction = position - transform.position;
        line.transform.right = direction;

        line.transform.localScale = new Vector3(direction.magnitude, 3, 3);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        hoverItem = this;
    }

    public void DisableLine(){
        Destroy(line);
    }
}