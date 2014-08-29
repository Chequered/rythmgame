using UnityEngine;
using System.Collections;

public class CreditsScreenCommands : MonoBehaviour {

	float relativeForce = 0.1f;
	float relativeWaitingtime = 0.01f;
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
			yield return new WaitForSeconds(relativeWaitingtime);
			StartCoroutine(CreditsButtonPushed());
		}
	}
	public void ExitCredits()	
	{
		StartCoroutine(ExitCreditsButtonPushed());
	}
	IEnumerator ExitCreditsButtonPushed()
	{
		screenPos = transform.position.x;
		if(screenPos > -2)
		{
			transform.position -= new Vector3(relativeForce, 0, 0);
			yield return new WaitForSeconds(relativeWaitingtime);
			StartCoroutine(ExitCreditsButtonPushed());
		}
	}
	public void StartGame(){
		StartCoroutine(StartGameButtonPushed());
	}
	IEnumerator StartGameButtonPushed(){
		screenPos = transform.position.x;
		if(screenPos > -3)
		{
			transform.position -= new Vector3(relativeForce, 0, 0);
			yield return new WaitForSeconds(relativeWaitingtime);
			StartCoroutine(StartGameButtonPushed());
		}
	}
}
