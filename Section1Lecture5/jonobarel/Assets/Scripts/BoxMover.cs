using UnityEngine;
using System.Collections;

public class BoxMover : MonoBehaviour {

	public float strafeSpeed = 0;
	public float speed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Strafespeed = " + strafeSpeed);	
		Debug.Log ("Speed = " + speed);

		float controlledSpeed = Input.GetAxis ("Vertical") * speed;
		float controlledStrafeSpeed = Input.GetAxis ("Horizontal") * strafeSpeed;

		Debug.Log ("Force (Speed,Strafespeed) = (" + controlledSpeed + ", " + controlledStrafeSpeed + ")");

		rigidbody.AddForce (controlledSpeed, 0, controlledStrafeSpeed);
	}
}
