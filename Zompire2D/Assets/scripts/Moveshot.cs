using UnityEngine;
using System.Collections;

public class Moveshot : MonoBehaviour {
	public float speed = 8.0f; // speed of the bullet
	private float timealive = 0.46f; // time the bullet will be in the game
	private float timer; // timer

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = transform.up * speed; // set the direction and speed of the bullet
		timer = timealive + Time.time; // set the timer that the bullet will be alive
	}
	void Update(){
		// destroy the bullet if the time runs out
		if (timer < Time.time){
			Destroy(gameObject);
		}

	}	

	void OnCollisionEnter2D(Collision2D hit){
		// destroy the bullet if it hits the wall, a cactus or a zombie 
		if(hit.gameObject.tag == "Wall" || hit.gameObject.tag == "Zombie" || hit.gameObject.tag == "cactus"){
			Destroy(gameObject);
		}


	}

}
