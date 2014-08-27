using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	public string direction;
	private float arrowSpeed;

	private void Start(){
		arrowSpeed = GameController.globalArrowSpeed;
		int stance = (int)Random.Range(0,3);
		transform.Rotate(new Vector3(0,0,stance * 90));
		if (stance == 0){
			direction = "right";
		}else if(stance == 1){
			direction = "up";
		}else if(stance == 2){
			direction = "left";
		}else if(stance == 3){
			direction = "down";
		}
	}

	Vector3 pos;
	private void Update(){
		pos.y = this.transform.position.y;
		pos.x = this.transform.position.x;
		pos.x -= arrowSpeed;
		pos.z = transform.position.z;
		this.transform.position = pos;
	}


	public string Direction {
		get {
			return direction;
		}
		set {
			direction = value;
		}
	}
}
