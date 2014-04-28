using UnityEngine;
using System.Collections;

	public class followplayer : MonoBehaviour {
	private Vector3 mypos;


	// Update is called once per frame
	void Update () {
		if (Gamemanagement.gameisalive == true){
			mypos = new Vector3 (-15,simple_movement.playerposy,-20);
			transform.position = mypos;
		}
		if ( Gamemanagement.gameisalive == false){
			mypos = new Vector3 (15,-33.79374f,-20);
			transform.position = mypos;
		}
	}
}
