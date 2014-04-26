using UnityEngine;
using System.Collections;

public class dosomething : MonoBehaviour {

	void OnCollisionEnter (Collision collider){
		if (collider.gameObject.tag == "Player"){

			animation.Play("trapanimation");
			Debug.Log("hey du der");
			audio.Play();

		}
	}
}
