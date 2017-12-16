using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //accessing the rigidbody2d component
    private Rigidbody2D rb;

    //accessing the paddle objects through the ball script
    public GameObject Paddle1;
    public GameObject Paddle2;

    //initializing te variables for the speed
    public static float NSpeed = -10f;
    public static float PSpeed = 10f;

	// Use this for initialization
	void Start () {

        //finding the paddles
        Paddle1 = GameObject.Find("Paddle1");
        Paddle2 = GameObject.Find("Paddle2");

        //finding the rigidbody2d component
        rb = GetComponent<Rigidbody2D>();

        //starts the function pause()
        StartCoroutine(Pause());
    }

    //a function that works only when a trigger occurs
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //if the right collider is hit the score of player 1 is increased by 1 and the ball is relocated to the middle
        if (hitInfo.name == "RightCollider")
        {
            Score.Paddle1Score++;
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }
        //if the left collider is hit the score of player 2 is increased by 1 and the ball is relocated to the middle
        else if (hitInfo.name == "LeftCollider")
        {
            Score.Paddle2Score++;
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }

        //checking the wat the ball hits the paddles
        else if (hitInfo.name == "Paddle1")
        {
           if (Paddle1.GetComponent<Rigidbody2D> ().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(PSpeed, PSpeed);
            }  
           else if (Paddle1.GetComponent<Rigidbody2D>().velocity.y < 0.5f)
            {
                rb.velocity = new Vector2(PSpeed, NSpeed);
            }
           else
            {
                rb.velocity = new Vector2(PSpeed, 0f);
            }
        }
        else if (hitInfo.name == "Paddle2")
        {
            if (Paddle2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(NSpeed, PSpeed);
            }
            else if (Paddle2.GetComponent<Rigidbody2D>().velocity.y < 0.5f)
            {
                rb.velocity = new Vector2(NSpeed, NSpeed);
            }
            else
            {
                rb.velocity = new Vector2(NSpeed, 0f);
            }
        }
    }

    //waits for 2 seconds before moving to the next action
    IEnumerator Pause()
    {
        //generating a random x dierction
        int directX = Random.Range(-1, 2);
        //generating a random y dierction
        int directY = Random.Range(-1, 2);

        //not allowing x direction to be 0 so there isnt vertical movement
        if (directX == 0)
        {
            directX = 1;
        }

        //setting the velocity of the ball to 0
        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2);
        //after the 2 second pause the ball moves in a direction
        rb.velocity = new Vector2(PSpeed * directX, PSpeed * directY);
    }


    
}
