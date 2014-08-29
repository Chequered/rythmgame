using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hitbox : MonoBehaviour {

	private string directionPressed; //richting van de pijl die ingedrukt is
	private List<GameObject> arrowsInHitBox = new List<GameObject>();
	private Vector3 startScale;
	private Vector3 danceScale;
	private Vector3 startPos;
	private Vector3 dancePos;


	public Sprite[] danceMoves; //de stances van de groovy monkey
	public GameObject gameControllerObj; //de Gamecontroller
	public GameObject light;
	public GameObject particleSystem;
	public GameObject player;

	private void Start(){
		startScale = new Vector3(4,4,0);
		danceScale = new Vector3(2,2,0);
		startPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
		dancePos = new Vector3(-2.9f, -0.028f, -1.4f);
	}

	private void OnTriggerEnter2D(Collider2D col){ //een collider in de hitbox komt
		if(col.transform.tag == "Arrow"){ //checkt of de collider een arrow is.
			arrowsInHitBox.Add(col.gameObject); //voegt hem toe aan de lijst met arrows die nu in de hitbox zitten.
		}
		light.light.enabled = true;
	}

	private void Update(){
		GetInput(); //Input van keyboard
		if(arrowsInHitBox.Count <= 0){
			light.light.enabled = false;
		}
		if(GameController.status && player.GetComponent<Animator>().enabled){
			player.GetComponent<Animator>().enabled = false;
		}
	}

	private bool hadOne;//een boolean die aangeeft of er een arrow goed was tijdens een foreach loop
	private void GetInput(){
		if(Input.GetKeyDown(KeyCode.UpArrow)){//als je de up arrow indrukt
			foreach(GameObject arrow in arrowsInHitBox){//een loop die de directie van elke arrow vergelijkt met de knop die ingedrukt word.
				if(arrow.GetComponent<Arrow>().Direction == "up"){ //als de richting klopt met de knop
					ProcessArrow(arrow);//do er dan iets meer
					Dance (0);
				}
			}
			if(!hadOne){//als er geen arrow goed was (dus als je de verkeerde knop hebt ingedrukt)
				gameControllerObj.GetComponent<GameController>().OnAction(false);//process hem dan
			}hadOne = false;//reset de boolean
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow)){//als je de right arrow indrukt
			foreach(GameObject arrow in arrowsInHitBox){
				if(arrow.GetComponent<Arrow>().Direction == "right"){
					ProcessArrow(arrow);
					Dance (1);
				}
			}
			if(!hadOne){
				gameControllerObj.GetComponent<GameController>().OnAction(false);
			}hadOne = false;
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow)){//als je de down arrow indrukt
			foreach(GameObject arrow in arrowsInHitBox){
				if(arrow.GetComponent<Arrow>().Direction == "down"){
					ProcessArrow(arrow);
					Dance (2);
				}
			}
			if(!hadOne){
				gameControllerObj.GetComponent<GameController>().OnAction(false);
			}hadOne = false;
		}
		else if(Input.GetKeyDown(KeyCode.LeftArrow)){//als je de left arrow indrukt
			foreach(GameObject arrow in arrowsInHitBox){
				if(arrow.GetComponent<Arrow>().Direction == "left"){
					ProcessArrow(arrow);
					Dance (3);
				}
			}
			if(!hadOne){
				gameControllerObj.GetComponent<GameController>().OnAction(false);
			}hadOne = false;
		}
	}

	private void Dance(int move){
		audio.Play();
		player.GetComponent<SpriteRenderer>().sprite = danceMoves[move];
		player.GetComponent<Animator>().enabled = false;
		player.transform.localScale = danceScale;
		player.transform.position = dancePos;
		Invoke ("DanceMonkeyDance", 0.3f);
	}

	private void DanceMonkeyDance(){
		player.GetComponent<Animator>().enabled = true;
		player.transform.localScale = startScale;
		player.transform.position = startPos;
	}

	private void ProcessArrow(GameObject arrow){
		gameControllerObj.GetComponent<GameController>().OnAction(true, this.transform.position.x, arrow.transform.position.x); //process de arrow
		hadOne = true; //reset the boolean
		arrowsInHitBox.Remove(arrow); //haal de arrow uit de array
		arrow.GetComponent<Arrow>().Explode(); //Vernietig de arrow en laat het gebouw exploderen.
		particleSystem.GetComponent<ParticleSystem>().Emit(50); //emit een paar particles
	}

	private void OnTriggerExit2D(Collider2D col){
		arrowsInHitBox.Remove(col.gameObject); //verwijder de arrow.
	}
}
