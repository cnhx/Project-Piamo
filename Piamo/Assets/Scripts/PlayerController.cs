using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public Vector2 moving = new Vector2();

	public 

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		moving.x = moving.y = 0;

		
//		if(Input.GetKey("right")) 
//		{
//			moving.x = 1;
//		} else if(Input.GetKey("left")){
//			moving.x = -1;
//		}
//		
//		if(Input.GetKey("up")){
//			moving.y = 1;
//		}
//		else if (Input.GetKey("down")){
//			moving.y = -1;
//		}

		foreach (Touch touch in Input.touches) {
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
			{
				if(touch.position.x<(Screen.width/2.0f)){
					moving.y = 1;
				}else{
					moving.x = 1;
				}
			}
			
		}

	
	}
}