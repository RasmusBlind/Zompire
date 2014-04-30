using UnityEngine;
using System.Collections;

/// <summary>
/// This script takes care of spawning the Zombies.
/// </summary>
public class enemy_spawn : MonoBehaviour {

	//Declaing variables
	public Transform EnemySpawn; //is public so it can be modified within unity. Can be attached to the enemy prefab, or other types of enemys.
	private float Timer;  // a timer of how long between each mudhole spawn
	public float nextspawn = 1.0f; //the time between each enemy spawn, set to a default of 1 second - can be modified in unity
	private float randomrangey; // to hold an random range for spawn in the y direction
	private float randomrangex; // to hold an random range for spawn in the x direction

	void Start() {
		Timer = Time.time + nextspawn; // set up timer for the first spawn

	}

	void Update () {
		if (Timer < Time.time && Gamemanagement.gameisalive == true) { //compares current time and time stored in the variable 
			randomrangey = Random.Range(-20.0f , 20.0f); //determines the range in y direction where enemys can spawn
			randomrangex = Random.Range(-3.5f , 3.5f); //determines the range in x directetion where enemys can spawn
			Vector2 spawnposition = new Vector2(transform.position.x + randomrangex , transform.position.y + randomrangey); //Finds a random position for an enemy within the range
			Instantiate(EnemySpawn, spawnposition, transform.rotation); //Instantiates/create the enemy at the random position
			Timer = Time.time + nextspawn; // recharge the timer
		}
		// destroy the spawner if the game is over
		if ( Gamemanagement.gameisalive == false){

			Destroy(gameObject);

		}
	}
}
