using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgress : MonoBehaviour
{
    public Quest quest;

    public void CurrentStatus(){
        if(quest.isActive){
            quest.goal.QuizTaken(); 
            if(quest.goal.IsReached()){
                Debug.Log("ALL Quiz is finished");
                quest.Complete();
            }
        }
    }
}
