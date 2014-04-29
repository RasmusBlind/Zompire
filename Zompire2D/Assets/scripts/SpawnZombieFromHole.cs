using UnityEngine;
using System.Collections;

public class SpawnZombieFromHole : MonoBehaviour {

	public GameObject ZombieToSpawn; // what enemy to spawn
	public float numberofspawns = 3.0f; // how many enemies to spawn from a hole
	public float timebetweenspawns = 0.5f; // time between each spawn

	private float spawntime; // the timer
	private float timessmaller = 10.0f; // how many times the hole gets smaller before it is destroyed
	// sets up the timer
	void Start(){
		spawntime = Time.time + timebetweenspawns;
	}

	// Update is called once per frame
	void Update () {

		// if the timer has runned out and the hole should spawn more zombies we will instantiate a zombie
		if (spawntime < Time.time && numberofspawns > 0.0f){
			Instantiate(ZombieToSpawn, transform.position, transform.rotation); // instantiation of the zombie 
			numberofspawns = numberofspawns - 1.0f; // subtact one from the number left to spawn
			spawntime = Time.time + timebetweenspawns; // set up new timer
		}
		// if there are no more zombie to be spawn the hole gets smaller 
		if (numberofspawns <= 0){
			transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
			timessmaller -= 1.0f; //subtract one from the times it has to do this agian 
		}

		// destroyd the gameObject when it is done
		if (timessmaller <= 0){
			Destroy(gameObject);
		}
		// also destroy the gameObject if the game has ended
		if (Gamemanagement.gameisalive == false){
			Destroy(gameObject);

		}
	
	}
}
