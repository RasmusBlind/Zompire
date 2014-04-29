using UnityEngine;
using System.Collections;

public class playgameoversound : MonoBehaviour {
	public static bool playonce = false;
	// Update is called once per frame	
	void Update () {
		if (playonce == true && Gamemanagement.gameisalive == false){
			audio.Play();
			playonce = false;
		}
	}
}
