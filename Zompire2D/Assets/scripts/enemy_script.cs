using UnityEngine;
using System.Collections;

public class enemy_script : MonoBehaviour {

	private Vector3 Player;
	private Vector2 PlayerDirection;
	private float Xdif; //x difference
	private float Ydif; //y difference

	void Start () {
	
	}


	void Update () {
	
		Player = GameObject.Find("Player").transform; //find the gameobject player

		Xdif = Player.x - transform.position.x; //Difference in x value
		Ydif = Player.y - transform.position.y;

		PlayerDirection = new Vector2 (Xdif, Ydif);

		rigidbody2D.AddForce(PlayerDirection.normalized) //Normalize so the amount of force is not dependant on the distance

	}
}
