using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {
	public string text;

	private void Start(){
		this.guiText.text = text + GameController.lives;
	}

	public void UpdateLives(int change){
		GameController.lives -= change;
		if(GameController.lives < 0){
			GameController.status = true;
		}
		this.guiText.text = text + GameController.lives;
	}
}
