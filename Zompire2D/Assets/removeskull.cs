using UnityEngine;
using System.Collections;

public class removeskull : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (Gamemanagement.gameisalive == true){
			Destroy(gameObject);

		}
	}
}
