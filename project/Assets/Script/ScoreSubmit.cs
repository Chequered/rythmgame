using UnityEngine;
using System.Collections;

public class ScoreSubmit : MonoBehaviour {

	public static string playerName = "Name";
	
	void OnGUI() {
		if(GameController.status){
			GUI.TextArea(new Rect(230, 50, 240, 180), "        Game Over!                                               Submit your score!");
			playerName = GUI.TextField(new Rect(250, 110, 200, 20), playerName, 25);
			if (GUI.Button(new Rect(250, 170, 50, 40), "Submit")){
				StartCoroutine(PostScores(playerName, (int) Score.globalScore));
			}
		}
	}

	public static IEnumerator PostScores(string name, int score)
	{
		string post_url = "daanruiter.net/gamejam_disco_submit.php?" + "NAME=" + name + "&SCORE=" + score;
		post_url = post_url.Replace(" ","_");
		
		WWW hs_post = new WWW(post_url);
		yield return hs_post; 
		
		if (hs_post.error != null)
		{
			print("There was an error posting the high score: " + hs_post.error);
		}
	}
}
