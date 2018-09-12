using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {
	
	// Player Movement Variables
	public int MoveSpeed;
	public float JumpHeight;

	// Player grounded variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {
		Grounded = Physics20.OverlapCircle(GroundCheck.Position, GroundCheckRadius, WhatIsGround);
	}




	// Update Is Called Once Per Frame
	void Update () {

		// This Code Makes The Character Jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
			
		}

		print ("Hello World");	
	}
	public void Jump(){
		GetComponent<Rigidbody2D>().Velocity = new Vector2(GetComponent<Rigidbody2D>().Velocity.x, JumpHeight);


	}
}
