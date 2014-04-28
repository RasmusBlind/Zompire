using UnityEngine;
using System.Collections;

public class makeflamesmaler : MonoBehaviour {
	private float timer;
	private float tillexit = 0.2f;
	void Start(){

		timer = Time.time +tillexit;

	}

	// Update is called once per frame
	void Update () {

		transform.localScale -= new Vector3(0.3f,0.3f, 0);
		if (Time.time> timer){

			Destroy(gameObject);
		}
	}
}
