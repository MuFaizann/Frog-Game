using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HiScoreTen : MonoBehaviour
{
    public Text NameTextTwo;

    // Update is called once per frame
    void Update()
{
    string highScoresText = "Top 10 High Scores:\n";
    for (int i = 0; i < ScoreTen.HighScores.Length; i++)
    {
        int score = ScoreTen.HighScores[i];
        highScoresText += (i + 1) + ". " + score + "\n";
    }

    NameTextTwo.text = highScoresText;
}

/*
     void Update()
    {
      //  NameTextTwo.text = Score.HighestPinCount.ToString();//////
       NameTextTwo.text = ScoreTen.HighScores.ToString();
    } 
    */
}

