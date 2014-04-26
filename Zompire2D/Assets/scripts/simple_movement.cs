using UnityEngine;
using System.Collections;

public class simple_movement : MonoBehaviour {
	public float speed = 2.0f;

	public float playerposy;
	void Update (){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2(moveHorizontal,moveVertical);

		rigidbody2D.velocity = movement * speed;

		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

		playerposy = transform.position.y;

	}
}
