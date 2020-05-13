using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;
	public float speed = 30;
	private int score = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
		{
			rb.AddForce(0f, 0f, speed);
		}
		if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
		{
			rb.AddForce(0f, 0f, -speed);
		}
		if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
		{
			rb.AddForce(-speed, 0f ,0f);
		}
		if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
		{
			rb.AddForce(speed, 0f, 0f);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Pickup")
		{
			score += 1;
			Debug.Log("Score: " + score);
			Destroy(other.gameObject);
		}
	}
}
