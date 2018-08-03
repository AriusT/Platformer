using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKiller : MonoBehaviour {
	public GameObject PlayerStartPosition;

	// Use this for initialization
	void Start () {
		// set the transform.position equal to that of the start position
	}

	private void OnTriggerEnter2D (Collider2D other){

		if (other.gameObject.name.StartsWith ("PK")) {
			transform.rotation = PlayerStartPosition.transform.rotation;
			transform.position = PlayerStartPosition.transform.position;

		}
	}
}
	