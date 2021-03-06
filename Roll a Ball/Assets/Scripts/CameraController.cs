using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player1;
    public GameObject player2;
    public float distancemultiplier;


    private Vector3 offsetfromcenter;
    Vector3 PlayersMidPoint()
    {
        return (player1.transform.position + player2.transform.position) / 2;
    }
    Vector3 DistanceBetweenPlayers()
    {
        return (player1.transform.position - player2.transform.position);
    }


    // Use this for initialization
    void Start () {
        offsetfromcenter = transform.position-((player1.transform.position + player2.transform.position) / 2);
	}
	

	// Update is called once per frame
	void LateUpdate () {
        transform.position = offsetfromcenter+(offsetfromcenter*DistanceBetweenPlayers().magnitude*distancemultiplier) + PlayersMidPoint();
	}
	//lets see if this is working
}
