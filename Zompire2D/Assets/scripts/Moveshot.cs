using UnityEngine;
using System.Collections;

public class Moveshot : MonoBehaviour {
	public float speed = 8.0f;
	private float timealive = 0.46f;
	private float timer;

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = transform.up * speed;
		timer = timealive + Time.time;
	}
	void Update(){
		if (timer < Time.time){
			Destroy(gameObject);
		}

	}	

	void OnCollisionEnter2D(Collision2D hit){
		if(hit.gameObject.tag == "Wall" || hit.gameObject.tag == "Zombie" || hit.gameObject.tag == "cactus"){
			Destroy(gameObject);
		}


	}

}
