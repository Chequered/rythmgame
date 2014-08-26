using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	private float score;

	public void UpdateScore(bool plus){
		if(plus){
			score += GameController.addedScore;
		}
		guiText.text = "" + score;
	}
}
