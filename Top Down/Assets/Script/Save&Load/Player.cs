using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] Quizzes;
    public void save()
    {
        SerializationManager.Save(this);
    }
    
    public void loadData()
    {        
        PlayerData playerdata = SerializationManager.Load();
        
        Vector3 position;
        position.x = playerdata.position[0];
        position.y = playerdata.position[1];
        position.z = playerdata.position[2];

        transform.position = position;

        gameObject.GetComponent<SpriteRenderer>().sortingLayerName = playerdata.sortingLayer;
        gameObject.gameObject.layer = LayerMask.NameToLayer(playerdata.sortingLayer);
        
        for(int i = 0;i < Quizzes.Length;i++)
        {
            Quizzes[i].GetComponent<Manager>().currentLevel = playerdata.Level[i];            
        }   
    }
}
