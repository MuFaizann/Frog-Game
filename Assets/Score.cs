using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int CurrentScore = 0;

	public static int HighestPinCount;

	public Text scoreText;

	void Start ()
	{
		scoreText.text = CurrentScore.ToString();
		HighestPinCount = PlayerPrefs.GetInt("highestPinCount", 0);
	}

	void Update ()
	{
		//text.text = PinCount.ToString();

		if (CurrentScore > HighestPinCount) {
		HighestPinCount = CurrentScore;
		PlayerPrefs.SetInt("highestPinCount", HighestPinCount);
	}
	}

}



/*
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int[] HighScores = new int[10];
    public static int CurrentScore = 0;

    public Text scoreText;

    void Start ()
    {
        scoreText.text = CurrentScore.ToString();

        for (int i = 0; i < HighScores.Length; i++)
        {
            HighScores[i] = PlayerPrefs.GetInt("highScore" + i, 0);
        }
    }

    void Update ()
    {
        scoreText.text = CurrentScore.ToString();

        for (int i = 0; i < HighScores.Length; i++)
        {
            if (CurrentScore > HighScores[i])
            {
                for (int j = HighScores.Length - 1; j > i; j--)
                {
                    HighScores[j] = HighScores[j - 1];
                }

                HighScores[i] = CurrentScore;

                for (int k = 0; k < HighScores.Length; k++)
                {
                    PlayerPrefs.SetInt("highScore" + k, HighScores[k]);
                }

                break;
            }
        }
    }
}
*/

/*
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int[] HighScores = new int[10];
    public static int CurrentScore = 0;

    public Text scoreText;

    void Start ()
    {
        scoreText.text = "High Scores:\n";

        for (int i = 0; i < HighScores.Length; i++)
        {
            int score = PlayerPrefs.GetInt("highScore" + i, 0);
            HighScores[i] = score;
            scoreText.text += (i+1) + ". " + score + "\n";
        }
    }

    void Update ()
{
    scoreText.text = CurrentScore.ToString();

    for (int i = 0; i < HighScores.Length; i++)
    {
        if (CurrentScore > HighScores[i])
        {
            for (int j = HighScores.Length - 1; j > i; j--)
            {
                HighScores[j] = HighScores[j - 1];
            }

            HighScores[i] = CurrentScore;

            for (int k = 0; k < HighScores.Length; k++)
            {
                PlayerPrefs.SetInt("highScore" + k, HighScores[k]);
            }

            scoreText.text = "High Scores:\n";
            for (int l = 0; l < HighScores.Length; l++)
            {
                scoreText.text += (l + 1) + ". " + HighScores[l] + "\n";
            }

            break;
        }
    }
}

}
*/