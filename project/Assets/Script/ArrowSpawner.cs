using UnityEngine;
using System.Collections;

public class ArrowSpawner : MonoBehaviour {

	public float[] spawnPoints;
	public GameObject hitBox;
	public GameObject Arrow;

	private void Start(){
		Vector3 pos = new Vector3(0, 0, -2.5f);
		for(int i = 0; i < spawnPoints.Length; i ++){
			pos.x = hitBox.transform.position.x + spawnPoints[i];
			if(pos.x > 0){
				pos.x = pos.x + spawnPoints[i] * 5.33f;
			}else
			pos.y = hitBox.transform.position.y;
			pos.z = hitBox.transform.position.z;
			GameObject arrow = GameObject.Instantiate(Arrow, pos, Quaternion.identity) as GameObject;
			arrow.GetComponent<Arrow>().ID = i;
		}
	}
}
