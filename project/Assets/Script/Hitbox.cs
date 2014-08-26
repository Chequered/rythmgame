using UnityEngine;
using System.Collections;

public class Hitbox : MonoBehaviour {

	private string directionInBox;
	public GameObject debugText;

	private void OnTriggerEnter2D(Collider2D col){
		if(col.transform.tag == "Arrow"){
			directionInBox = col.GetComponent<Arrow>().Direction;
			Debug.Log (directionInBox);
			debugText.GetComponent<DEBUG>().UpdateDEBUG(directionInBox);
		}
	}

	private void OnTriggerExit2D(Collider2D col){
		directionInBox = "none";
		debugText.GetComponent<DEBUG>().UpdateDEBUG(directionInBox);
	}
}
