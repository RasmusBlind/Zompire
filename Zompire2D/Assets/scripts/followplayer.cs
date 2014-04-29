using UnityEngine;
using System.Collections;

	public class followplayer : MonoBehaviour {
	private Vector3 mypos; // used to move the cam to different possitions 
	public AudioListener myaudiooncam; // here goes the audiolistener of the gameObject
	public static bool win = false;
	public Transform playerTransform;

	public static followplayer instance; //SINGELTON (THE WEIRD EDITION)

	void Awake(){
		instance = this;
	}

	void Update () {
		// if the game is alive we will move to the players position
		if (Gamemanagement.gameisalive == true){
			//mypos = new Vector3 (-15,simple_movement.playerposy,-1);
			mypos = new Vector3 (-15,playerTransform.position.y,-1);

			transform.position = mypos;
		}
		// if the game is dead and it is the first time the game is played  we will move the cam to the titel screen
		if ( Gamemanagement.gameisalive == false && Gamemanagement.firsttime == true && win == false){
			mypos = new Vector3 (15,-33.79374f,-1);
			transform.position = mypos; // move the cam
		}
		// if the player die the cam will be moved to the gameover screen  if it is not the first time
		if ( Gamemanagement.gameisalive == false && Gamemanagement.firsttime == false && win == false){
			mypos = new Vector3 (15,-10,-1);
			transform.position = mypos;
		}
		// will move the camera to the win screen
		if ( Gamemanagement.gameisalive == false && Gamemanagement.firsttime == false && win == true){
			mypos = new Vector3 (50,-10,-1);
			transform.position = mypos;
		}
		// enable and disable the audio listener of the camera this is because we want a audiolistener on the cam when we see the titel screen and the gameover screen
		// and we do not want to have two audiolistener
		if (Gamemanagement.gameisalive == true){
			myaudiooncam.enabled = false; // disable the audiolistener
		} else {
			myaudiooncam.enabled = true; // enable the audiolistener
		}
	}
}
