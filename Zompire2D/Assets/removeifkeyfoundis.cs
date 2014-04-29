using UnityEngine;
using System.Collections;

public class removeifkeyfoundis : MonoBehaviour {
	

	//  this script make sure that all key disapear if the player has the key
	void Update () {
		if(simple_movement.gotkey == true){

			Destroy (gameObject);
		}
	}
}
