using UnityEngine;
using System.Collections;

public class turnwithplayer : MonoBehaviour {
	public Transform playerrotation;

	// Update is called once per frame
	void Update () {
		transform.rotation = playerrotation.rotation;
	}
}
