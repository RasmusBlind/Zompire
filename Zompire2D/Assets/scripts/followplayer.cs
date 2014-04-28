using UnityEngine;
using System.Collections;

	public class followplayer : MonoBehaviour {
	private Vector3 mypos;


	// Update is called once per frame
	void Update () {

		mypos = new Vector3 (-15,simple_movement.playerposy,-20);
		transform.position = mypos;
	}
}
