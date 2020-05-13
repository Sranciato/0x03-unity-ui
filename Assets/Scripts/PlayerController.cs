using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody rigidbody;
	public float speed = 30;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
		{
			rigidbody.AddForce(0f, 0f, speed);
		}
		if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
		{
			rigidbody.AddForce(0f, 0f, -speed);
		}
		if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
		{
			rigidbody.AddForce(-speed, 0f ,0f);
		}
		if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
		{
			rigidbody.AddForce(speed, 0f, 0f);
		}
	}
}
