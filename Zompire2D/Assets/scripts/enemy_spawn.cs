using UnityEngine;
using System.Collections;

public class enemy_spawn : MonoBehaviour {

	public Transform EnemySpawn;
	private float Timer;
	public float nextspawn = 1.0f;

	void Start() {
		Timer = Time.time + nextspawn;

	}

	void Update () {
		if (Timer < Time.time) {
			Instantiate(EnemySpawn, transform.position, transform.rotation);
			Timer = Time.time + nextspawn;
		}
	}
}
