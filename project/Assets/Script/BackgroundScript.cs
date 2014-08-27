using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {

	public float scrollSpeed;
	public float offset;
	
	// Update is called once per frame
	void Update () {
		if(!GameController.status){
			offset += scrollSpeed;
			renderer.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
			if (offset >= 1) 
			{
				offset = -1;
				renderer.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
			}
		}
	}
}
