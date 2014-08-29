using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {
	public GameObject loseScreenGUI;
	private void Start(){
		this.guiText.text = "Lives: " + GameController.lives;
	}

	public void UpdateLives(int change){
		GameController.lives -= change;
<<<<<<< HEAD
		if(GameController.lives == 0){
=======
		if(GameController.lives < 0){
			loseScreenGUI.GetComponent<LoseScreen>().Lost();
>>>>>>> 4c03c0f62a7c311b911ed93a47e55f2d45247878
			GameController.status = true;
		}
		guiText.text = "Lives: " + GameController.lives;
	}
}
