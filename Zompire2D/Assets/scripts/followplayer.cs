using UnityEngine;
using System.Collections;

	public class followplayer : MonoBehaviour {
	private Vector3 mypos;
	public AudioListener myaudiooncam;



	// Update is called once per frame
	void Update () {
		if (Gamemanagement.gameisalive == true){
			mypos = new Vector3 (-15,simple_movement.playerposy,-1);
			transform.position = mypos;
		}
		if ( Gamemanagement.gameisalive == false && Gamemanagement.firsttime == true){
			mypos = new Vector3 (15,-33.79374f,-1);
			transform.position = mypos;
		}
		if ( Gamemanagement.gameisalive == false && Gamemanagement.firsttime == false){
			mypos = new Vector3 (15,-10,-1);
			transform.position = mypos;
		}
		if (Gamemanagement.gameisalive == true){
			myaudiooncam.enabled = false;
		} else {
			myaudiooncam.enabled = true;
		}
	}
}
