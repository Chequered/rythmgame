using UnityEngine;
using System.Collections;

public class ScoreSubmit : MonoBehaviour {

	public static string playerName = "Name";
	
	void OnGUI() {
		if(GameController.status){

			playerName = GUI.TextField(new Rect(30, 260, 200, 20), playerName, 25);
			if (GUI.Button(new Rect(30, 320, 50, 40), "Submit")){
				StartCoroutine(PostScores(playerName, (int) Score.globalScore));
			}
			if(GameController.lives == 0){
				GUI.TextArea(new Rect(10, 200, 240, 180), "        Game Over!                                                You booggied yourself to death!                     Submit your score!");
			}else{
				GUI.TextArea(new Rect(10, 200, 240, 180), "        Game Over!                                                You destroyed the town with your grooy moves!               Submit your score!");
			}
		}
	}

	public static IEnumerator PostScores(string name, int score)
	{
		string post_url = "gamejam_disco_submit.php?" + "NAME=" + name + "&SCORE=" + score;
		post_url = post_url.Replace(" ","_");
		
		WWW hs_post = new WWW(post_url);
		yield return hs_post; 
		
		if (hs_post.error != null)
		{
			print("There was an error posting the high score: " + hs_post.error);
		}
	}
}
