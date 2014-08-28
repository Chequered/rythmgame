using UnityEngine;
using System.Collections;

public class CreditsScreenCommands : MonoBehaviour {

	float relativeForce = 0.1f;
	float screenPos;
	public void GoCredits()	
	{
		StartCoroutine(CreditsButtonPushed());
	}
	IEnumerator CreditsButtonPushed()
	{
		screenPos = transform.position.x;
		if(screenPos < 0)
		{
			transform.position += new Vector3(relativeForce, 0, 0);
			yield return new WaitForSeconds(0.01f);
			StartCoroutine(CreditsButtonPushed());
		}
	}
	public void ExitCredits()	
	{
		StartCoroutine(ExitCreditsButtonPushed());
	}
	IEnumerator ExitCreditsButtonPushed()
	{
		screenPos = this.transform.position.x;
		if(screenPos > -2)
		{
			transform.position -= new Vector3(relativeForce, 0, 0);
			yield return new WaitForSeconds(0.01f);
			StartCoroutine(ExitCreditsButtonPushed());
		}
	}
}
