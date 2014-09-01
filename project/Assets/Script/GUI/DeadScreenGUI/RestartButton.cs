using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

	void Awake(){
		guiTexture.texture = button1;
	}
	public Texture2D button1;
	public Texture2D button2;
	public GameObject allRelativeComponents;
	public GameObject creditsScreenCommands;
	void OnMouseDown(){
		guiTexture.texture = button2;
	}
	void OnMouseUp(){
		Vector2 mousepos = Input.mousePosition;
		if(guiTexture.HitTest(mousepos))
		{
			Application.LoadLevel(0);
			GameController.status = false;
			creditsScreenCommands.GetComponent<CreditsScreenCommands>().StartGame();
		}
		guiTexture.texture = button1;
	}
}
