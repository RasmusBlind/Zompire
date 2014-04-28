using UnityEngine;
using System.Collections;

//The Zombie Interaction Script is added to the "enemy", so when enemy is hit by the bullet, enemy is destroyed automatically.

public class ZombieInteractionScript : MonoBehaviour {

	public Transform BloodSplash;
	public GameObject key;

	private float dropchance = 1.0f;
	//public Transform SkullInTheSand;
	private float droprate;
	private bool keyhasdropped = false;

	void OnCollisionEnter2D(Collision2D Hit){
		if (Hit.gameObject.tag == "Bullet"){
			ScoreController.score+=10; //The score increments
			Destroy (gameObject);
			Instantiate(BloodSplash,transform.position,Quaternion.identity);
			droprate = Random.Range(0.0f,100.0f);

			if (droprate < dropchance && keyhasdropped == false){
				Instantiate(key,transform.position,Quaternion.identity);
				keyhasdropped = true;
			}


		}
	}
	void OnCollisionStay2D(Collision2D playerHit){
		if (playerHit.gameObject.tag == "Player"){
			simple_movement.playerhealth -= 0.5f;

			Debug.Log(simple_movement.playerhealth);

		}
		
	}
}