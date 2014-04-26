using UnityEngine;
using System.Collections;

public class CubeCollider : MonoBehaviour {

	private void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.name == "Player") {
			Destroy(collision.gameObject);
		}

	}

}