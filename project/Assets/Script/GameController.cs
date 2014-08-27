using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public float _globalArrowSpeed;
	public int startingHealth;
	public float bonusPoints;
	public GameObject scoreText; //de text van de score
	public GameObject livesText; //de text van de levens

	public static int lives;
	public static float globalArrowSpeed;

	private void Awake(){
		lives = startingHealth;
		globalArrowSpeed = _globalArrowSpeed;
	}

	float distance;
	float score;
	public void OnAction(bool correctButton, float hitBoxPos, float arrowPos){
		distance = (hitBoxPos - arrowPos);
		if(distance > 0){
			distance = distance * Random.Range(22, 25);
		}else{
			distance = distance *- Random.Range(22, 25);
		}
		Debug.Log (distance);
		score = bonusPoints - distance;
		Debug.Log (score);
		scoreText.GetComponent<Score>().UpdateScore(correctButton,(int) score);
		if(!correctButton){
			livesText.GetComponent<Lives>().UpdateLives(1);
		}
	}

	public void OnAction(bool correctButton){
		scoreText.GetComponent<Score>().UpdateScore(correctButton, (int) score);
		if(!correctButton){
			livesText.GetComponent<Lives>().UpdateLives(1);
		}
	}
}
