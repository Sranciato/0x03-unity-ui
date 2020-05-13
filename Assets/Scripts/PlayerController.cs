using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;
	public float speed = 30;
	private int score = 0;
	public int health = 5;
	// Use this for initialization
	void Start () {
		
	}
	void Update ()
	{
		if (health == 0)
		{
			Debug.Log("Game Over!");
			SceneManager.LoadScene(0);
		}
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
		if (other.tag == "Trap")
		{
			health -= 1;
			Debug.Log("Health: " + health);
		}
		if (other.tag == "Goal")
		{
			Debug.Log("You win!");
		}
	}
}
