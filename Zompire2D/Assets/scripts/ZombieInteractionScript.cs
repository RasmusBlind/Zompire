using UnityEngine;
using System.Collections;

public class ZombieInteractionScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D Hit){
		if (Hit.gameObject.tag == "Bullet"){
			ScoreController.score+=10; //The score increments

			Destroy (gameObject);

		}
	}
}