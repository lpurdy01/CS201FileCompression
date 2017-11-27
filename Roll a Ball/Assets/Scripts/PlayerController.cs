using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public int jumpHeight;
	public Text countText;
	public Text winText;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		winText.text = "";
		SetCountText ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Jump ();
		}
	}
		
	private Rigidbody rb;
	private int count; 

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rb.AddForce (movement*speed);
	}

	void Jump () {
		Vector3 jump = new Vector3 (0, jumpHeight, 0);

		rb.AddForce (jump*speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count++;
			SetCountText ();
		}
	}

	void SetCountText () {
		countText.text = "Count: " + count.ToString();
		if (count == 8) {
			winText.text = "You Win!";
			//winText.enabled = true;
		}
	}
}