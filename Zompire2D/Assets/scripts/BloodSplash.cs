using UnityEngine;
using System.Collections;

public class BloodSplash : MonoBehaviour {

	//private float Seconds= 1.0f;
	void Start() {
		Destroy(gameObject,5);
	}
}
