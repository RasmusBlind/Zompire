﻿using UnityEngine;
using System.Collections;

//The Zombie Interaction Script is added to the "enemy", so when enemy is hit by the bullet, enemy is destroyed automatically.

public class ZombieInteractionScript : MonoBehaviour {

	public Transform BloodSplash;
	//public Transform SkullInTheSand;

	void OnCollisionEnter2D(Collision2D Hit){
		if (Hit.gameObject.tag == "Bullet"){
			ScoreController.score+=10; //The score increments
			Destroy (gameObject);
			Instantiate(BloodSplash,transform.position,Quaternion.identity);
		}
	}
	void OnCollisionStay2D(Collision2D playerHit){
		if (playerHit.gameObject.tag == "Player"){
			simple_movement.playerhealth -= 0.5f;

			Debug.Log(simple_movement.playerhealth);

		}
		
	}
}