using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour {

    public Text countText;
    public Text winText;
    public static int count;


    // Use this for initialization
    void Start () {
        SetCountText();
        winText.text = "";
        count = 0;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count == 4)
        {
            winText.text = "You Win!";
            //winText.enabled = true;
        }
    }
}
