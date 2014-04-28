using UnityEngine;
using System.Collections;

public class Gamemanagement : MonoBehaviour {
	public static bool gameisalive = false;
	public GameObject player;
	public GameObject spawner;
	private Vector3 playerpos;
	private Vector3 spawnerpos;
	// Use this for initialization
	void Start () {
		playerpos = new Vector3(-14.99599f, -39.40869f, 0.0f);
		spawnerpos = new Vector3(-15.0f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.P) && gameisalive == false){
			Instantiate(player, playerpos, Quaternion.identity);
			Instantiate(spawner, spawnerpos , Quaternion.identity);
			gameisalive = true;
		}
	}
}
