using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int[] Level;
    public float[] position;
    public string sortingLayer;
    public PlayerData (Player player)
    {        
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;

        sortingLayer = player.GetComponent<SpriteRenderer>().sortingLayerName;

        Level = new int[player.Quizzes.Length];
        for(int i = 0; i<player.Quizzes.Length;i++)
        {             
            Level[i] = player.Quizzes[i].GetComponent<QuizManager>().currentLevel;
        }
        
    }
}
