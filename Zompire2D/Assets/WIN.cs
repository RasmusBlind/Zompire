using UnityEngine;
using System.Collections;

public class WIN : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D win){
		// if the player had the key and get to the bar he will win the game 
		if (win.gameObject.tag == "Player" && simple_movement.gotkey == true){
			followplayer.win = true; // player win is set to true 
			Gamemanagement.gameisalive = false;  // the game will end
			simple_movement.playerhealth = 0.0f; // we remove the player from the game

		}
	}
}