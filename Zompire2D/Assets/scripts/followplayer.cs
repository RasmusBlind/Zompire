using UnityEngine;
using System.Collections;

public class followplayer : MonoBehaviour {
	private Vector3 mypos;
	public Transform Player;
	// Update is called once per frame
	void Update () {
		mypos = new Vector3 (0,1,-20);
			transform.position = Player.position +  mypos;
	
	}
}
