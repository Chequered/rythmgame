using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

	private void Start(){
		this.guiText.text = "Lives: " + GameController.lives;
	}

	public void UpdateLives(int change){
		GameController.lives -= change;
		if(GameController.lives < 0){
			GameController.status = true;
		}
		guiText.text = "Lives: " + GameController.lives;
	}
}
