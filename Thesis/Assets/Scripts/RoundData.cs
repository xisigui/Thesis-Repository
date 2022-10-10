using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RoundData
{
    public string name;
    public int timeLimitInSeconds;

    public int pointsAddedForCorrectAnswers;

    //Array that holds a number of questions
    public QuestionData[] questions;
}
