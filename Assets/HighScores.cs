/* using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class HighScores : MonoBehaviour {

    public Text highScoresText;

    void Start()
    {
        // Load high scores from PlayerPrefs
        List<int> highScores = new List<int>();
        for (int i = 1; i <= 10; i++) {
            int score = PlayerPrefs.GetInt("HighScore" + i, 0);
            if (score > 0) {
                highScores.Add(score);
            }
        }

        // Add current score to high scores list
        highScores.Add(Score.CurrentScore);

        // Sort high scores list in descending order
        highScores = highScores.OrderByDescending(score => score).ToList();

        // Save top 10 high scores to PlayerPrefs
        for (int i = 1; i <= 10; i++) {
            int score = i <= highScores.Count ? highScores[i - 1] : 0;
            PlayerPrefs.SetInt("HighScore" + i, score);
        }

        // Build high scores string
        string highScoresString = "HIGH SCORES:\n\n";
        for (int i = 1; i <= 10; i++) {
            int score = PlayerPrefs.GetInt("HighScore" + i, 0);
            if (score > 0) {
                highScoresString += i + ". " + score + "\n";
            }
        }

        // Display high scores string in UI text object
        highScoresText.text = highScoresString;
    }
    
    void Update()
    {
        // Call the public Start() method of the Score script to update the CurrentScore variable
        Score scoreScript = GetComponent<Score>();
        if (scoreScript != null) {
            scoreScript.Start();
        }
    }
}
*/