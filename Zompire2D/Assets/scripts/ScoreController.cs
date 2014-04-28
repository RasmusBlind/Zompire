using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public static int score = 0; //static means that all scripts have acces to this variable

	void OnGui() {
		string scoreText = "Score: " + score;

		GUI.Box (new Rect((Screen.width/2) - 200,0,300,30), scoreText); //where the gui box will be placed
	}	

}
