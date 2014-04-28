using UnityEngine;
using System.Collections;

public class enemy_direction : MonoBehaviour {
	/// <summary>
	/// This script makes the enemy follow the player
	/// </summary>

	//Declaring variables
	private GameObject target; //the enemy needs a target (player)
	public float moveSpeed; //the speed of the enemy is public so it can be modified in unity

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		target = GameObject.FindGameObjectWithTag("Player"); //The target, which the enemy should follow or hunt, has the tag Player
		transform.rotation = Quaternion.LookRotation(Vector3.forward, target.transform.position - transform.position); //this makes the enemy look at the target (player)
		rigidbody2D.velocity = transform.up * moveSpeed; //the movement speed

	}
}
