using UnityEngine;
using System.Collections;

public class enemy_direction : MonoBehaviour {

	private GameObject target; // who the zombie follow
	public float moveSpeed = 3.0f; // the Zombies movement speed

	
	// Update is called once per frame
	void Update () {
		// finds the player by tag
		target = GameObject.FindGameObjectWithTag("Player");
		// set rotation to the player
		transform.rotation = Quaternion.LookRotation(Vector3.forward, target.transform.position - transform.position);
		// makes the Zombie move towards the player
		rigidbody2D.velocity = transform.up * moveSpeed;

		// destroy the zombie when the game ends
		if(Gamemanagement.gameisalive == false){
			Destroy(gameObject);

		}
	}
}
