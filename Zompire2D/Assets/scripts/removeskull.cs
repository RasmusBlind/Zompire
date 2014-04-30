using UnityEngine;
using System.Collections;

public class removeskull : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		// remove skull if the game starts
		if (Gamemanagement.gameisalive == true){
			Destroy(gameObject);

		}
	}
}
