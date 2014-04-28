using UnityEngine;
using System.Collections;

public class Moveshot : MonoBehaviour {
	public float speed = 8.0f;

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = transform.up * speed;
	}

	void OnCollisionEnter2D(Collision2D hit){
		if(hit.gameObject.tag == "Wall" || hit.gameObject.tag == "Zombie" || hit.gameObject.tag == "cactus"){
			Destroy(gameObject);
		}

	}

}
