using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;

    public PlayerProgress player;

    public void AcceptQuest(){
        quest.isActive =true;
        player.quest = quest;
    }
}

