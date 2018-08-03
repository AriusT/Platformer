using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void Update() {

		if (Input.GetKey (KeyCode.RightArrow))
			transform.Translate (.125f, 0, 0);
		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Translate (-.125f, 0, 0);


	}
}
