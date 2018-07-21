using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour {

	private int speed = 1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// Moves the balloon up at a constant speed
		transform.Translate(Vector3.up * speed * Time.deltaTime);
	}

	// Destroy the balloon once it is clicked
	void OnMouseDown (){
		// Plays an explosion animation and sound
		

		// Destroys the gameobject itself
		Destroy(gameObject);
	}
}
