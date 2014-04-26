using UnityEngine;
using System.Collections;

public class simple_movement : MonoBehaviour {
	public float speed = 2.0f;
	void Update (){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2(moveHorizontal,moveVertical);

		rigidbody2D.velocity = movement * speed;

	}
}
