using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HiscoreGet : MonoBehaviour
{
    public Text NameTextTwo;
/*
    // Update is called once per frame
    void Update()
{
    string highScoresText = "Top 10 High Scores:\n";
    for (int i = 0; i < Score.HighScores.Length; i++)
    {
        int score = Score.HighScores[i];
        highScoresText += (i + 1) + ". " + score + "\n";
    }

    NameTextTwo.text = highScoresText;
}
*/

     void Update()
    {
        NameTextTwo.text = Score.HighestPinCount.ToString();
      // NameTextTwo.text = Score.HighScores.ToString();
    } 
    
}

