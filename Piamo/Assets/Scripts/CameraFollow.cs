using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject target;

	private Transform _t;

	// Use this for initialization
	void Start () {
		_t = target.transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (_t.transform.position.x+4, _t.transform.position.y+2, transform.position.z);
	}
}
