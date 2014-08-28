using UnityEngine;
using System.Collections;

public class ExplosionAnim : MonoBehaviour {

	public GameObject particles;

	public void InvokeMe(){
		Destroy(this.gameObject, 0.55f);
		GameObject particleObj = GameObject.Instantiate(particles, new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z), Quaternion.identity) as GameObject;
		Destroy(particleObj.gameObject, 2f);
	}
}
