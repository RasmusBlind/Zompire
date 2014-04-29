using UnityEngine;
using System.Collections;

//The Zombie Interaction Script is added to the "enemy", so when enemy is hit by the bullet, enemy is destroyed automatically.

public class ZombieInteractionScript : MonoBehaviour {

	public Transform BloodSplash; // holds a blood splash to be spawned on dead
	public GameObject key; // holds the key

	private float dropchance = 1.0f; // drop chance of the key 
	private float droprate; // a float to check if the key should drop


	void OnCollisionEnter2D(Collision2D Hit){
		// if the bullets hit the Zombie it will die and the key might drop
		if (Hit.gameObject.tag == "Bullet"){
			ScoreController.score+=10; //The score increments

			Instantiate(BloodSplash,transform.position,Quaternion.identity); // make the bloodsplash
			droprate = Random.Range(0.0f,100.0f); // take the drop chance of the key
			// check if the key has dropped and if the key should drop
			if (droprate < dropchance){
				Instantiate(key,transform.position,Quaternion.identity); // instantiate  the key
			}
			Destroy (gameObject); // destroy the Zombie
		}
	}

	void OnCollisionStay2D(Collision2D playerHit){
		//if the zombie collid with the player makes the player loose health
		if (playerHit.gameObject.tag == "Player"){
			simple_movement.playerhealth -= 0.5f; // removes health from the player

		}
		
	}
}