using UnityEngine;
using System.Collections;

public class removeblod : MonoBehaviour {
	private float timer;
	private float tillexit = 1.0f;
	// Use this for initialization
	void Start () {
		timer = Time.time +tillexit;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time> timer){
			
			Destroy(gameObject);
		}
	}
}
