using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public float _globalArrowSpeed;
	public static int lives;
	public static float globalArrowSpeed;

	private void Start(){
		globalArrowSpeed = _globalArrowSpeed;
	}

	public static void OnMistake(){
//		Lives.UpdateLives();
	}
}
