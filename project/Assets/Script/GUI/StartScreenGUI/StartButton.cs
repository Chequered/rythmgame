using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartButton : MonoBehaviour {

	void Awake(){
		guiTexture.texture = button1;
	}
	public Texture2D button1;
	public Texture2D button2;
	public GameObject creditsGUI;
	void OnMouseDown(){
		guiTexture.texture = button2;
	}
	void OnMouseUp(){
		Vector2 mousepos = Input.mousePosition;
		if(guiTexture.HitTest(mousepos))
		{
			ButtonPushed();
		}
		guiTexture.texture = button1;
	}
	public void ButtonPushed(){
		creditsGUI.GetComponent<CreditsScreenCommands>().StartGame();
	}
}
