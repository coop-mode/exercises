using UnityEngine;
using System.Collections;

public class SphereMover : MonoBehaviour {

	public float Speed;
	public float StrafeSpeed;

	// Use this for initialization
	void Start () 
	{
		Speed = 2;
		StrafeSpeed = 2;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log ("speed is " + Speed);
		Debug.Log ("strafe speed is " + StrafeSpeed);
	
		float controlledSpeed = Input.GetAxis ("Horizontal") * Speed;
		float controlledStrafe = Input.GetAxis ("Vertical") * StrafeSpeed;

		rigidbody.AddForce (controlledSpeed, 0, controlledStrafe, ForceMode.Force);
	}
}
