using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hitbox : MonoBehaviour {

	private string directionPressed; //richting van de pijl die ingedrukt is
	private List<GameObject> arrowsInHitBox = new List<GameObject>();

	public GameObject debugText; //de text van de richting van de pijl in de hitbox
	public GameObject GameController; //de Gamecontroller

	private void OnTriggerEnter2D(Collider2D col){
		if(col.transform.tag == "Arrow"){
			arrowsInHitBox.Add(col.gameObject);
		}
	}

	private void Update(){
		GetInput();
		Debug.Log (arrowsInHitBox.Count);
	}

	private bool hadOne;
	private void GetInput(){
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			foreach(GameObject arrow in arrowsInHitBox){
				if(arrow.GetComponent<Arrow>().Direction == "up"){
					ProcessArrow(arrow);
				}
			}
			if(!hadOne){
				GameController.GetComponent<GameController>().OnAction(false);
			}hadOne = false;
		}
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			foreach(GameObject arrow in arrowsInHitBox){
				if(arrow.GetComponent<Arrow>().Direction == "right"){
					ProcessArrow(arrow);
				}
			}
			if(!hadOne){
				GameController.GetComponent<GameController>().OnAction(false);
			}hadOne = false;
		}
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			foreach(GameObject arrow in arrowsInHitBox){
				if(arrow.GetComponent<Arrow>().Direction == "down"){
					ProcessArrow(arrow);
				}
			}
			if(!hadOne){
				GameController.GetComponent<GameController>().OnAction(false);
			}hadOne = false;
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			foreach(GameObject arrow in arrowsInHitBox){
				if(arrow.GetComponent<Arrow>().Direction == "left"){
					ProcessArrow(arrow);
				}
			}
			if(!hadOne){
				GameController.GetComponent<GameController>().OnAction(false);
			}hadOne = false;
		}
	}

	private void ProcessArrow(GameObject arrow){
		GameController.GetComponent<GameController>().OnAction(true);
		hadOne = true;
		arrowsInHitBox.Remove(arrow);
		Destroy(arrow.gameObject);
	}

	private void OnTriggerExit2D(Collider2D col){
		arrowsInHitBox.Remove(col.gameObject);
	}
}
