using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {
	public GameObject loseScreenGUI;
	private void Start(){
		this.guiText.text = "Lives: " + GameController.lives;
	}

	public void UpdateLives(int change){
		GameController.lives -= change;
		if(GameController.lives < 0){
			loseScreenGUI.GetComponent<LoseScreen>().Lost();
			GameController.status = true;
		}
		guiText.text = "Lives: " + GameController.lives;
	}
}
