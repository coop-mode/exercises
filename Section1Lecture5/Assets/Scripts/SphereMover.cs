using UnityEngine;
using System.Collections;

public class SphereMover : MonoBehaviour {

	public float speed;
	public float strafe_speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log ("speed is " + speed);
		Debug.Log ("strafe speed is " + strafe_speed);
	
	}
}
