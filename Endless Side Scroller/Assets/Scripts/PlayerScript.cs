using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float JUMP_POWER = 10.0f;

	Rigidbody2D myBody;
	public bool grounded = false;

	// Use this for initialization
	void Start () {
		myBody = transform.GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		// if user presses space and we are grounded, then jump
		if (Input.GetKeyDown (KeyCode.Space) && grounded) {

			//jump
			myBody.AddForce (Vector3.up * (JUMP_POWER * myBody.mass * myBody.gravityScale * 20.0f));

		}
		
	}

	//called when first collides, sets grounded
	void OnCollisionEnter2D (Collision2D other){

		//if the tag of what we just collided with is "Ground"
		if (other.collider.tag == "Ground") {
			grounded = true;
		}

	}

	//called during continious collision, sets grounded to false
	void OnCollisionStay2D (Collision2D other){

		//if the tag of what we just collided with is "Ground"
		if (other.collider.tag == "Ground") {
			grounded = true;
		}

	}

	//called when collisison ends, sets grounded to false
	void OnCollisionExit2D (Collision2D other){

		//if the tag of what we just collided with is "Ground"
		if (other.collider.tag == "Ground") {
			grounded = false;
		}

	}
}
