using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {
	public string text;

	private void Start(){
		this.guiText.text = text + GameController.lives;
	}

	public static void UpdateLives(int change){

	}
}
