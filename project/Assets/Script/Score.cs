using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public static float score;

	public static float globalScore;

	public void UpdateScore(bool plus, int _score){
		if(plus){
			score += _score;
			globalScore = score;
		}
		guiText.text = "Score: " + score;
	}
}
