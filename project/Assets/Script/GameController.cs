using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public float _globalArrowSpeed;
	public int startingHealth;
	public float bonusPoints;
	public GameObject scoreText; //de text van de score
	public GameObject livesText; //de text van de levens

	public static int lives;
	public static float globalArrowSpeed;
	public static bool status;
	public static List<GameObject> arrowsInGame = new List<GameObject>();

	private void Update(){
		Debug.Log (arrowsInGame.Count);
		if(arrowsInGame.Count <= 0){
			status = true;
		}
	}

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
		score = bonusPoints - distance;
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
