using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	public string direction;
	private float arrowSpeed;

	private void Start(){
		arrowSpeed = GameController.globalArrowSpeed;
	}

	Vector2 pos;
	private void Update(){
		pos.y = this.transform.position.y;
		pos.x = this.transform.position.x;
		pos.x -= arrowSpeed;
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
