using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour {

	public GameObject explosion;

	public void Explode(){
		GameObject explosionObj = GameObject.Instantiate(explosion, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity) as GameObject;
		explosionObj.GetComponent<ExplosionAnim>().InvokeMe();
		Destroy(this.gameObject);
	}
}
