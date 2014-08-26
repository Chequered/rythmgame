using UnityEngine;
using System.Collections;

public class DEBUG : MonoBehaviour {
	
	public void UpdateDEBUG(string txt){
		Debug.Log ("UPDATEDEBUG");
		this.guiText.text = txt;
	}
}
