using UnityEngine;
using System.Collections;

public class showhealth : MonoBehaviour {

	private float curhealth;
	// Update is called once per frame
	void Update () {
		curhealth = simple_movement.playerhealth/100;
		if(curhealth>=0.0f){
			transform.localScale = new Vector3(1 * curhealth ,1,1);
		}
	}
}
