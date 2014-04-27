using UnityEngine;
using System.Collections;

public class enemy_spawn : MonoBehaviour {

	public Transform EnemySpawn;
	private float Timer;

	void Start() {
		Timer = Time.time +1;

	}

	void Update () {
		if (Timer < Time.time) {
			Instantiate(EnemySpawn, transform.position, transform.rotation);
			Timer = Time.time +1;
		}
	}
}
