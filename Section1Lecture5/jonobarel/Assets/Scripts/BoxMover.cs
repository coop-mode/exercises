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
	}
}
