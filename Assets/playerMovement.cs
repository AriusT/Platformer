using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public float maxSpeed = 10f;

	// Update is called once per frame
	void Update() {


		transform.Translate (Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime, 0, 0);



	}
}
