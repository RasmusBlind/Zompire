﻿using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public static int score = 0; //static means that all scripts have acces to this variable

	void OnGUI() {
		string scoreText = "Score: " + score; // set a string with the score

		GUI.Label(new Rect(60, 70, 100, 20), scoreText); //where the gui box will be placed
	}	

}
