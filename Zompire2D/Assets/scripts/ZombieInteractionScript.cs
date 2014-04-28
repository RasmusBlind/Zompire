using UnityEngine;
using System.Collections;

//The Zombie Interaction Script is added to the "enemy", so when enemy is hit by the bullet, enemy is destroyed automatically.

public class ZombieInteractionScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D Hit){
		if (Hit.gameObject.tag == "Bullet"){
			Destroy (gameObject);
		}
	}
}