using UnityEngine;
using UnityEngine.UI;

public class scoreTst : MonoBehaviour {

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