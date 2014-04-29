using UnityEngine;
using System.Collections;

public class Gamemanagement : MonoBehaviour {
	public static bool gameisalive = false; // used to see if the game has started or not static so it can be seen from other scripts
	public static bool firsttime = true; // make sure that first time we start the game that the titel sceen will be shown
	public GameObject player; // take the player gameObject to be instantiated
	public GameObject spawner; // take the spawner gameObject to be instantiated
	private Vector3 playerpos; // this vector will be where the player will be instantiated
	private Vector3 spawnerpos; // this vector will be where the spawner will be instantiated

	public static bool keyhasdropped = false; // should make sure that the key to win the game do not drop two times

	void Start () {
		playerpos = new Vector3(-14.99599f, -39.40869f, 0.0f); // here the position of the player is set
		spawnerpos = new Vector3(-15.0f, 0.0f, 0.0f); // here the position of the spawner is set
	}
	

	void Update () {
		if (Input.GetKeyUp(KeyCode.P) && gameisalive == false){ // look for if the key P has been pressed and if the game is not alive if not instantiate player and spawner

			Instantiate(player, playerpos, Quaternion.identity); // instantiate the player at his position
			Instantiate(spawner, spawnerpos , Quaternion.identity); // instantiate the spawner at its position
			gameisalive = true; // set the game to be alive
			ScoreController.score = 0; // set the score to 0 in the ScoreController Script
			simple_movement.playerhealth = 100; // set the health to 100 in the movement script
			firsttime = false; // make sure that next time game stop it will go to game over screen in stead of titel
			keyhasdropped = false; // so the key can drop agian

		}

	}
}
