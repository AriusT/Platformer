using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {
	public GameObject PlayerStartPosition;


	Rigidbody2D rb;

	void Awake(){
		rb = GetComponent<Rigidbody2D> ();
		ResetPlayer ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.R)) {
			ResetPlayer ();
		}



	}

	void ResetPlayer () {
		transform.rotation = PlayerStartPosition.transform.rotation;
		transform.position = PlayerStartPosition.transform.position;
		rb.velocity = Vector2.zero;

	}
}
