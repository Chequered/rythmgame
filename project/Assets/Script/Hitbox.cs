using UnityEngine;
using System.Collections;

public class Hitbox : MonoBehaviour {

	private string directionInBox; //richting van de pijl in de hitbox
	private string directionPressed; //richting van de pijl die ingedrukt is

	public GameObject debugText; //de text van de richting van de pijl in de hitbox
	public GameObject GameController; //de Gamecontroller

	private void OnTriggerEnter2D(Collider2D col){
		if(col.transform.tag == "Arrow"){
			directionInBox = col.GetComponent<Arrow>().Direction;
			debugText.GetComponent<DEBUG>().UpdateDEBUG(directionInBox);
		}
	}

	private void Update(){
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			directionPressed = "down";
			if(directionInBox == directionPressed){
				GameController.GetComponent<GameController>().OnAction(true);
			}else{
				GameController.GetComponent<GameController>().OnAction(false);
			}
		}else if(Input.GetKeyDown(KeyCode.RightArrow)){
			directionPressed = "right";
			if(directionInBox == directionPressed){
				GameController.GetComponent<GameController>().OnAction(true);
			}else{
				GameController.GetComponent<GameController>().OnAction(false);
			}
		}else if(Input.GetKeyDown(KeyCode.UpArrow)){
			directionPressed = "up";
			if(directionInBox == directionPressed){
				GameController.GetComponent<GameController>().OnAction(true);
			}else{
				GameController.GetComponent<GameController>().OnAction(false);
			}
		}else if(Input.GetKeyDown(KeyCode.LeftArrow)){
			directionPressed = "left";
			if(directionInBox == directionPressed){
				GameController.GetComponent<GameController>().OnAction(true);
			}else{
				GameController.GetComponent<GameController>().OnAction(false);
			}
		}
	}

	private void OnTriggerExit2D(Collider2D col){
		directionInBox = "none";
		debugText.GetComponent<DEBUG>().UpdateDEBUG(directionInBox);
	}
}
