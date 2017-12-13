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
	
	// Update is called once per frame
	void Update () {

        // if the ball moves beyond a certain point, it is relocated to the center of the game
        if(this.transform.position.x >= 18.5f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
        if(this.transform.position.x <= -18.5f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }

	}
}
