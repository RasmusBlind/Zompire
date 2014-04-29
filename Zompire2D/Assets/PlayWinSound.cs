using UnityEngine;
using System.Collections;

public class PlayWinSound : MonoBehaviour {

	void Update () {
		if ( playgameoversound.playonce == true && Gamemanagement.gameisalive == false && Gamemanagement.firsttime == false && followplayer.win == true){
			audio.Play();
			playgameoversound.playonce = false;
		}
	}
}
