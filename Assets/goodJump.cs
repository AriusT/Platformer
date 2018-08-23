using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodJump : MonoBehaviour {

	public float fallMultiplier = 2.5f;
	public float lowJumpMultiplier = 2f;

	Rigidbody2D rb;

	[Range(1, 10)]
	public float jumpVelocity;

	void Awake(){
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update(){
		if (Input.GetButtonDown ("Jump")) {
			rb.velocity = Vector2.up * jumpVelocity;
		}

		if (rb.velocity.y < 0) {
			rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
		} else if (rb.velocity.y > 0 && !Input.GetButton ("Jump")) {
			rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
		}
				

	}
	// Use this for initialization
	void Start () {
		
	}
	

}
