using UnityEngine;
using System.Collections;

/// <summary>
/// This script takes care of spawning the Zombies.
/// </summary>
public class enemy_spawn : MonoBehaviour {

	//Declaing variables
	public Transform EnemySpawn; //is public so it can be modified within unity. Can be attached to the enemy prefab, or other types of enemys.
	private float Timer; 
	public float nextspawn = 1.0f; //the time between each enemy spawn, set to a default of 1 second - can be modified in unity
	private float randomrangey;
	private float randomrangex;

	void Start() {
		Timer = Time.time + nextspawn; 

	}

	void Update () {
		if (Timer < Time.time) { //compares current time and time stored in the variable 
			randomrangey = Random.Range(-15.0f , 10.0f); //determines the range in y direction where enemys can spawn
			randomrangex = Random.Range(-1f , 1f); //determines the range in x directetion where enemys can spawn
			Vector2 spawnposition = new Vector2(transform.position.x + randomrangex , transform.position.y + randomrangey); //Finds a random position for an enemy within the range
			Instantiate(EnemySpawn, spawnposition, transform.rotation); //Instantiates/create the enemy at the random position
			Timer = Time.time + nextspawn;
		}
	}
}
