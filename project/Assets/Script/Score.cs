using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	private float score;

	public void UpdateScore(bool plus, int _score){
		if(plus){
			score += _score;
		}
		guiText.text = "" + score;
	}
}
