using UnityEngine;
using System.Collections;

public class CreditsScreenCommands : MonoBehaviour {

	float relativeForce = 0.2f;
	public void GoCredits()
	{
		StartCoroutine(CreditsButtonPushed());
	}
	IEnumerator CreditsButtonPushed(){
		Debug.Log("something is happening");
		if(transform.position.x <= -0.2f)
		{
			transform.position += new Vector3(relativeForce, 0, 0);
			yield return new WaitForSeconds(0.00002f);
			StartCoroutine(CreditsButtonPushed());
		}
	}
	public void ExitCredits(){
		StartCoroutine(ExitCreditsButtonPushed());
	}
	IEnumerator ExitCreditsButtonPushed(){
		if(transform.position.x >= -15f)
		{
			transform.position -= new Vector3(relativeForce, 0, 0);
			yield return new WaitForSeconds(0.00002f);
			StartCoroutine(ExitCreditsButtonPushed());
		}
	}
}
