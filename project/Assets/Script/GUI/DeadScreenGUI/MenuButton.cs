using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {

	void Awake(){
		guiTexture.texture = button1;
	}
	public Texture2D button1;
	public Texture2D button2;
	void OnMouseDown(){
		guiTexture.texture = button2;
	}
	void OnMouseUp(){
		Vector2 mousepos = Input.mousePosition;
		if(guiTexture.HitTest(mousepos))
		{
			Application.LoadLevel(0);
		}
		guiTexture.texture = button1;
	}
}