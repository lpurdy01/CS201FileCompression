using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour {

    public Text player1count;
    public Text player2count;
    public Text winText;
    public static int count1;
    public static int count2;
    public static int winnumber;

    public Material player1Meterial;
    public Material player2Meterial;
    private int player;


    // Use this for initialization
    void Start () {
        SetCountText();
        winText.text = "";
        count1 = 0;
        count2 = 0;
        player = 0;
        winnumber = 5;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision was made");
        if (other.gameObject.CompareTag("Player1"))
        {
            GetComponent<Renderer>().material = player1Meterial;
            player = 1;
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            GetComponent<Renderer>().material = player2Meterial;
            player = 2;
        }
        if (other.gameObject.CompareTag("Pick Up"))
        {
            if(player == 1)
            {
                count1++;
                SetCountText();
                Destroy(gameObject);
            }
            if (player == 2)
            {
                count2++;
                SetCountText();
                Destroy(gameObject);
            }
            if (player == 0)
            {
                transform.position = new Vector3(0, 1, 0);
            }

            SetCountText();
        }
        
    }

    void SetCountText()
    {
        player1count.text = "Player1 Score: " + count1.ToString();
        player2count.text = "Player2 Score: " + count2.ToString();
        if (count1+count2 == winnumber)
        {
            if(count1 > count2)
            {
                winText.text = "Player 1 Wins!";
            }
            else if (count2 > count1)
            {
                winText.text = "Player 2 Wins!";
            }
            else
            {
                winText.text = "You Win!";
            }

                //winText.enabled = true;
            }
    }
}
