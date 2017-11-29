using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour {

	public float speed;
	public int jumpHeight;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Jump ();
		}
		if (Input.GetKeyDown(KeyCode.RightAlt))
		{
			Fall ();
		}
	}

	private Rigidbody rb;

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal2");
		float moveVertical = Input.GetAxis ("Vertical2");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rb.AddForce (movement*speed);
	}

	void Jump () {
		Vector3 jump = new Vector3 (0, jumpHeight, 0);

		rb.AddForce (jump*speed);
	}
	void Fall()
	{
		Vector3 fall = new Vector3(0, -jumpHeight, 0);

		rb.AddForce(fall * speed);
	}


}