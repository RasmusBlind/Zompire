using UnityEngine;
using System.Collections;
// Element to remove blood on scene
public class BloodSplash : MonoBehaviour {

	void Start() {
		Destroy(gameObject,5);
	}
}
