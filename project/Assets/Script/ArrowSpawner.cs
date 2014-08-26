using UnityEngine;
using System.Collections;

public class ArrowSpawner : MonoBehaviour {

	public float[] spawnPoints;
	public GameObject hitBox;
	public GameObject Arrow;

	private int arrows;

	private void Start(){
		arrows = spawnPoints.Length;
		Vector3 pos = new Vector3(0,0,0);
		for(int i = 0; i < spawnPoints.Length; i ++){
			pos.x = hitBox.transform.position.x + 3 + spawnPoints[i];
			pos.y = hitBox.transform.position.y;
			GameObject arrow = Instantiate(Arrow, pos, Quaternion.identity) as GameObject;
		}
	}
}
