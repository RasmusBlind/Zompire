using UnityEngine;
using System.Collections;

public class enemy_direction : MonoBehaviour {

	private GameObject target;
	public float moveSpeed;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		target = GameObject.FindGameObjectWithTag("Player");
		transform.rotation = Quaternion.LookRotation(Vector3.forward, target.transform.position - transform.position);
		rigidbody2D.velocity = transform.up * moveSpeed;

		if(Gamemanagement.gameisalive == false){
			Destroy(gameObject);

		}

	}
}
