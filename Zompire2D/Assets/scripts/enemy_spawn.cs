using UnityEngine;
using System.Collections;

public class enemy_spawn : MonoBehaviour {

	public Transform EnemySpawn;
	private float Timer;
	public float nextspawn = 1.0f;
	private float randomrangey;
	private float randomrangex;

	void Start() {
		Timer = Time.time + nextspawn;

	}

	void Update () {
		if (Timer < Time.time) {
			randomrangey = Random.Range(-20.0f , 20.0f);
			randomrangex = Random.Range(-4.5f , 5.0f);
			Vector2 spawnposition = new Vector2(transform.position.x + randomrangex , transform.position.y + randomrangey);
			Instantiate(EnemySpawn, spawnposition, transform.rotation);
			Timer = Time.time + nextspawn;
		}
	}
}
