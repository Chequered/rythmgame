using UnityEngine;
using System.Collections;

public class ArrowSpawner : MonoBehaviour {

	public float[] spawnPoints;
	public GameObject hitBox;
	public GameObject Arrow;

	private void Start(){
		Vector3 pos = new Vector3(0, 0, -2.5f);
		for(int i = 0; i < spawnPoints.Length; i ++){
			pos.x = hitBox.transform.position.x + 3 + spawnPoints[i];
			pos.y = hitBox.transform.position.y;
			pos.z = hitBox.transform.position.z;
			Instantiate(Arrow, pos, Quaternion.identity);
		}
	}
}
