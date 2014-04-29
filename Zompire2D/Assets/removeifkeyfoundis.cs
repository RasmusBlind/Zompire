using UnityEngine;
using System.Collections;

public class removeifkeyfoundis : MonoBehaviour {
	

	// Update is called once per frame
	void Update () {
		if(simple_movement.gotkey == true){

			Destroy (gameObject);
		}
	}
}
