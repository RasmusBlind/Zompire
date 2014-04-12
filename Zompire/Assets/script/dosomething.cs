using UnityEngine;
using System.Collections;

public class dosomething : MonoBehaviour {

	void OnCollisionEnter (Collision collider){
		if (collider.gameObject.tag == "Player"){
			collider.rigidbody.AddForce(Vector3.back * 1 * Time.deltaTime);
			Debug.Log("hey du der");
			audio.Play();

		}
	}
}
