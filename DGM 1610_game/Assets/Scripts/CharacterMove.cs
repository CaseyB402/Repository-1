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
		Grounded = Physics2D.OverlapCircle(GroundCheck.Position, GroundCheckRadius, WhatIsGround);
	}




	// Update Is Called Once Per Frame
	void Update () {

		// This Code Makes The Character Jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
			
		}
	// This Makes The Character Move From Side To Side
	if(Input.GetKey (KeyCode.D)){
		GetComponent<RigidBody2D>().Velocity = new Vector2(MoveSpeed, GetComponent<RigidBody2D>().Velocity.y);
	}
	if(Input.GetKey (KeyCode.A)){
		GetComponent<RigidBody2D>().Velocity = new Vector2(-MoveSpeed, GetComponent<RigidBody2D>().Velocity.y);
	}
	
	}
	public void Jump(){
		GetComponent<Rigidbody2D>().Velocity = new Vector2(GetComponent<Rigidbody2D>().Velocity.x, JumpHeight);

	

	}
}
