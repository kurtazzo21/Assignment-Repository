using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //accessing the rigidbody2d component
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        //finding the rigidbody2d component
        rb = GetComponent<Rigidbody2D>();

        //the direction in which the ball travels
        rb.velocity = new Vector2 (6f, 6f);
    }

    //a function that works only when a trigger occurs
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //if the right collider is hit the score of player 1 is increased by 1 and the ball is relocated to the middle
        if (hitInfo.name == "RightCollider")
        {
            Score.Paddle1Score++;
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
        //if the left collider is hit the score of player 2 is increased by 1 and the ball is relocated to the middle
        else if (hitInfo.name == "LeftCollider")
        {
            Score.Paddle2Score++;
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
    }
    
}
