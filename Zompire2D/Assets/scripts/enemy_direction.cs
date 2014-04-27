using UnityEngine;
using System.Collections;

public class enemy_direction : MonoBehaviour {

	public Transform target;
	public float moveSpeed;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.LookRotation(Vector3.forward, target.position-transform.position);
		rigidbody2D.velocity = transform.up * moveSpeed;

	}
}
