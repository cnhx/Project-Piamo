using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10f;	
	public Vector2 maxVelocity = new Vector2(3,5);
	public float jetSpeed = 15f;
	public float airSpeedMultiplier = .3f;

	private PlayerController controller;
	private bool isStanding = true;
	
	void Start(){

		controller = GetComponent<PlayerController> ();

		}
	// Update is called once per frame
	void Update () {
		var forceX = 0f;
		var forceY = 0f;
		
		var absVelX = Mathf.Abs (rigidbody2D.velocity.x);
		var absVelY = Mathf.Abs (rigidbody2D.velocity.y);

		if (absVelY < .2f) {
						isStanding = true;
				} else {
			isStanding = false;
		}

		if (controller.moving.x != 0) {
			if(absVelX < maxVelocity.x){
				forceX = isStanding ? (speed * controller.moving.x) : (speed * controller.moving.x * airSpeedMultiplier);
				transform.localScale = new Vector3(forceX > 0 ? .6f: -.6f, .6f, 1);
		}
		}

		if (controller.moving.y > 0) {
				if (absVelY < maxVelocity.y) 
						forceY = jetSpeed * controller.moving.y;
				}

		rigidbody2D.AddForce(new Vector2(forceX,forceY));
}
}