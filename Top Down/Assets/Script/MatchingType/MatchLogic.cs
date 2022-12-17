using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MatchLogic : MonoBehaviour
{
    static MatchLogic Instance;

    public int maxPoints = 3;
    public TMP_Text pointText;
    public GameObject levelCompleteUI;
    private int points = 0;


    void Start(){
        Instance = this;
    }

    void UpdatePointstext(){
        pointText.text = points + "/" + maxPoints;
        if(points == maxPoints){
            levelCompleteUI.SetActive(true);
        }
    }

    public static void AddPoint(){
        AddPoints(1);
    }

    public static void AddPoints(int points){
        Instance.points += points;
        Instance.UpdatePointstext();
    }
}
