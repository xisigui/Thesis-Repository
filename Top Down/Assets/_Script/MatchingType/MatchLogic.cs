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
    public GameObject continueButton;
    public GameObject gameCanvas;

    public Quest quest;
    
    MatchItem matchItem;
    private int points = 0;


    void Start(){
        Instance = this;
        continueButton.transform.localScale = Vector3.zero;
       
    }

    void UpdatePointstext(){
        pointText.text = points + "/" + maxPoints;
        if(points == maxPoints){
            quest.FinishQuest();
            levelCompleteUI.SetActive(true);
            //continueButton.SetActive(true);
            continueButton.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
        }
    }

    public static void AddPoint(){
        AddPoints(1);
    }

    public static void AddPoints(int points){
        Instance.points += points;
        Instance.UpdatePointstext();
    }

    public void ContinueButton(){
        gameCanvas.SetActive(false);
        //gameCanvas.transform.localScale = Vector3.zero;
        points = 0;
        pointText.text = points + "/" + maxPoints;
        matchItem.DisableLine();
        
    }
}
