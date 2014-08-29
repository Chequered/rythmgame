using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	public string direction;
	public GameObject buildingPrefab;
	public int iD;

	private float arrowSpeed;
	private GameObject associatedBuilding;

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

		Vector3 pos = new Vector3(transform.position.x, transform.position.y + 2, -1.5f);
		if(direction == "right"){
			pos.x += 1.5f;
		}else if(direction == "left"){
			pos.x -= 1.5f;
		}
		GameObject building = GameObject.Instantiate(buildingPrefab, pos, Quaternion.identity) as GameObject;
		building.gameObject.name = "Building";
		building.transform.parent = this.transform;
		associatedBuilding = building;
	}

	Vector3 pos;
	private void Update(){
		if(!GameController.status){
			pos.y = this.transform.position.y;
			pos.x = this.transform.position.x;
			pos.x -= arrowSpeed;
			pos.z = transform.position.z;
			this.transform.position = pos;
		}
	}

	public void Explode(){
		associatedBuilding.GetComponent<Building>().Explode();
		Debug.Log ("Arrow: " + ID);
		Destroy(this.gameObject);
	}

	public int ID {
		get {
			return iD;
		}
		set {
			iD = value;
		}
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
