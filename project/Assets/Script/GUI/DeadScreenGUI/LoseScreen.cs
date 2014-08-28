using UnityEngine;
using System.Collections;

public class LoseScreen : MonoBehaviour {

	public float relativeForce = 0.02f;
	public IEnumerator YouLostMotherFucker(){
		if(transform.position.y > 0.5)
		{
			transform.position -= new Vector3(0, relativeForce, 0);
			yield return new WaitForSeconds(0.02f);
			StartCoroutine(YouLostMotherFucker());
		}
	}
}

