using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public float _globalArrowSpeed;
	public int startingHealth;
	public GameObject scoreText; //de text van de score
	public GameObject livesText; //de text van de levens

	public static int addedScore;
	public static int lives;
	public static float globalArrowSpeed;

	private void Awake(){
		Debug.Log ("GC");
		lives = startingHealth;
		globalArrowSpeed = _globalArrowSpeed;
		addedScore = 50;
	}

	public void OnAction(bool correctButton){
		scoreText.GetComponent<Score>().UpdateScore(correctButton);
		if(!correctButton){
			livesText.GetComponent<Lives>().UpdateLives(1);
		}
	}
}
