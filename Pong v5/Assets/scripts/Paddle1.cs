using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour {

    //accessing the rigidbody2d component
    private Rigidbody2D rb;
    

	// Use this for initialization
	void Start () {

        //finding the rigidbody2d component
        rb = this.GetComponent<Rigidbody2D> ();
        	
	}
	
	// Update is called once per frame
	void Update () {
		
        // if the key w is pressed the paddle moves up
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0f, 10f);
        }
        //if the key s is pressed the paddle moves down
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0f, -10f);
        }
        //if nothing is pressed the paddle stays in the same position
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }

    }
}
