using UnityEngine;
using System.Collections;

public class simple_movement : MonoBehaviour {
	public float speed = 2.0f; // this float will change the speed of the charcater it is pubilc for testing reasons
	public Transform position1; // this is the possition of one of the pistol barrols
	public Transform position2; // this is the possition of the other barrols
	private float nextfire; // this is the timer to next shot 
	public static float playerhealth = 100.0f; // this float is the players health it is static so it is easier to acces from other scripts

	public GameObject bullet; // this GameObject will hold the projectile tha the player can shoot

	public static float playerposy; // this is use as refrense to move the camera (should also be static)
	public float firerate = 0.5f; // this float will set how much time between each shot

	public AudioSource shoot; // this is the Audio for the shot
	public AudioSource cactushurt; // this is the Audio for when the player is hurt by the cactur
	public AudioSource deathrattle;
	private bool hitbycactus = false; // this is use to make the push back of the character
	public float pushbackforce = 5; // this will set the pushback force when the character is hit by the cactus

	private bool playonce = true; // make sure that the audio on death only plays once
	private float dethtime;   // set the time of how long the player takes to die
	public GameObject skull; // hold an object to be the Players skull


	public static bool gotkey = false; // a bool that will be set to true if the player gets the key

	private bool shotpos = true; // with this bool i change barrol of the gun shot
	void Update (){
		float moveHorizontal = Input.GetAxis ("Horizontal"); // this will get a number between -1 and 1 we  use it to move the player in the x axis
		float moveVertical = Input.GetAxis ("Vertical"); // this will get a number between -1 and 1 we  use it to move the player in the y axis

		Vector2 movement = new Vector2(moveHorizontal,moveVertical); // here we make the move vector
		 
		if (hitbycactus == false){ 
			rigidbody2D.velocity = movement * speed; // this will move the character if he is not hit by the cactus
		} else {
			hitbycactus = false; // make sure that we go make to not hit by cactus 
			rigidbody2D.velocity = movement * speed * -pushbackforce; // here we will push back the character if he is hit by cactus
		}
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // here we get the position of the mouse
		transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position); // here we make sure that the character is facing the mouse

		playerposy = transform.position.y;// here we get the possiton of the player in the y axis this is use to move the camera in another script

		if (Input.GetButton("Fire1") & Time.time > nextfire){ // check for input of fire and check if the character can shoot 
			nextfire = firerate + Time.time;// set the new timer 
			if (shotpos == true){ // of shoot pos is true we use one barrol if false the other
				Instantiate(bullet, position1.position, transform.rotation); // instantiate the bullet at one of the barrols
				shotpos = false; // changes barrol
			} else {
				Instantiate(bullet, position2.position, transform.rotation); // instantiate the bullet at the other barrol
				shotpos = true; // changes barrol
			}
			shoot.Play(); // play the soud of shooting
		}
		// this if statement will check if the player is dead
		if (playerhealth < 0.0f){
			if(playonce == true){ // we play the audio once 
				dethtime = Time.time + 1.2f; // set death timer
				deathrattle.Play (); // plays deathrattle audio
				playonce = false;
			}
			
			if(dethtime<Time.time){
				Destroy(gameObject); // if the player has 0 health he is kill by removing him from the game
				Instantiate(skull,transform.position,transform.rotation);  // instantiate a skull at the dead position
				Gamemanagement.gameisalive = false;// set the game to be "dead"
				playgameoversound.playonce = true; // next time the player die we can play the audio again
			}


		}
	}

	void OnCollisionEnter2D(Collision2D hit){
		if( hit.gameObject.tag == "cactus"){// if the player collide with the cactus he will loose health and the pushback bool will be true
			playerhealth -= 1.0f; // subtract health from the player
			hitbycactus = true; // for push back effect
			cactushurt.Play(); // plays sound of cacturhurt 
		}
		// if the player collide with the key he will have the key and can win the game
		if ( hit.gameObject.tag == "key"){
			gotkey = true; // the boolean that that chang if the player has the key
			Destroy(hit.gameObject); // destroy the key
		}
	}
}
