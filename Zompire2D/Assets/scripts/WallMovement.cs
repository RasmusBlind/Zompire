using UnityEngine;
using System.Collections;

public class WallMovement : MonoBehaviour {


	public Transform player; //a public transform variable so it can be accesd in unity, and we can drag/drop the player as the player
	private Vector2 newPosition; //variable that stores the new position x and y

	void Awake() {
		newPosition = transform.position; //sets the value to the current position
	}

	void Update() {
		Vector2 positionA = new Vector2(0, 2); //position A is the first position (from A) - it is placed at (0, 2) on the level
		Vector2 positionB = new Vector2(-11, 2); //position B is the end position (to B) - it will be placed at (-11, 2) on the level

		if(player.transform.position.y < 2) { //if the player's position is below the y value of 2 (which is the y value of the walls y coordinate in both position A and B) ...
			newPosition = positionA; //the position will be at position A (0,2)
		}
		if(player.transform.position.y >= 2) { //if the players position is equal to or above the y value 2 - so if the player has passed this place on the level ...
			newPosition = positionB; // the new position of the wall will be equal to positionB

		}

		transform.position = Vector2.Lerp (transform.position, newPosition, Time.deltaTime); //by using lerp the wall goes from position A to B (when activated)
	
	}

}
