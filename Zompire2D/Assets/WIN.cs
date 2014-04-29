using UnityEngine;
using System.Collections;

public class WIN : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D win){
		if (win.gameObject.tag == "Player" && simple_movement.gotkey == true){

			Gamemanagement.gameisalive = false; 
			simple_movement.playerhealth = 0.0f;

		}
	}
}