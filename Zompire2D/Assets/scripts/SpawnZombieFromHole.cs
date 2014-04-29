using UnityEngine;
using System.Collections;

public class SpawnZombieFromHole : MonoBehaviour {

	public GameObject ZombieToSpawn;
	public float numberofspawns = 3.0f;
	public float timebetweenspawns = 0.5f;

	private float spawntime;
	private float timessmaller = 10.0f;

	void Start(){
		spawntime = Time.time + timebetweenspawns;
	}

	// Update is called once per frame
	void Update () {


		if (spawntime < Time.time && numberofspawns > 0.0f){
			Instantiate(ZombieToSpawn, transform.position, transform.rotation);
			numberofspawns = numberofspawns - 1.0f;
			spawntime = Time.time + timebetweenspawns;
		}

		if (numberofspawns <= 0){
			transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
			timessmaller -= 1.0f;
		}

		if (timessmaller <= 0){
			Destroy(gameObject);
		}
		if (Gamemanagement.gameisalive == false){
			Destroy(gameObject);

		}
	
	}
}
