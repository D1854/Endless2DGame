using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeManager : MonoBehaviour {

	public float SCROLL_SPEED = 5.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//scrolling

		GameObject currentChild; // (BAD CODE - THIS SHOULD BE DEFINED EARLIER)

		//Loops through all the children of the object
		for (int i = 0; i < transform.childCount; i++) {

			//Get child at current index
			currentChild = transform.GetChild (i).gameObject;

			//Sends the object to be scrolled
			ScrollChallenge (currentChild);

		}


	}



	void ScrollChallenge (GameObject currentChallenege)
	{

		currentChallenge.transform.position -= Vector3.right * (SCROLL_SPEED * Time.deltaTime);


	}

}
