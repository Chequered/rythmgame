using UnityEngine;
using System.Collections;

public class AllGUITexts : MonoBehaviour {

	public GUIText GUILives;
	public GUIText GUIScore;
	private float totalLives;
	private float totalScore;

	public void UpdateScoreOrLives(){
		totalLives = GameController.lives;
		totalScore = Score.score;
		GUILives.text = "Lives: " + totalLives;
		GUIScore.text = "Score: " + totalScore;
	}

}
