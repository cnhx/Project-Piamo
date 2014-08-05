﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2(3,5);
	
	
	// Update is called once per frame
	void Update () {
		var forceX = 0f;
		var forceY = 0f;
		
		var absVelX = Mathf.Abs (rigidbody2D.velocity.x);
		
		if (Input.GetKey("right")){
			if(absVelX < maxVelocity.x){
				forceX = speed;

				transform.localScale = new Vector3(0.6,0.6,1); //flip the character to match the direction
			}
		} else if(Input.GetKey("left")){
			if(absVelX < maxVelocity.x){
				forceX = -speed;
				
				transform.localScale = new Vector3(-0.6,0.6,1);
			}
		}
		
		rigidbody2D.AddForce(new Vector2(forceX,forceY));
	}
}
