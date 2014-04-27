using UnityEngine;
using System.Collections;

public class simple_movement : MonoBehaviour {
	public float speed = 2.0f;
	public Transform position1;
	public Transform position2;
	private float nextfire;

	public GameObject bullet;

	public float playerposy;
	public float firerate = 0.5f;


	private bool shotpos = true;
	void Update (){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2(moveHorizontal,moveVertical);

		rigidbody2D.velocity = movement * speed;

		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

		playerposy = transform.position.y;

		if (Input.GetButton("Fire1") & Time.time > nextfire){
			nextfire = firerate + Time.time;
			if (shotpos == true){
				Instantiate(bullet, position1.position, transform.rotation);
				shotpos = false;
			} else {
				Instantiate(bullet, position2.position, transform.rotation);
				shotpos = true;
			}
		}



	}
}
