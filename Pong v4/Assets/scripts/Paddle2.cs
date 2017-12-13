using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour
{

    //accessing the rigidbody2d component
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {

        //finding the rigidbody2d component
        rb = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update () {
        //if the left button on the mouse is pressed the paddle moves up
        if (Input.GetMouseButton(0))
        {
            rb.velocity = new Vector2(0f, 7f);
        }
        //if the right button on the mouse is pressed the paddle moves down
        else if (Input.GetMouseButton(1))
        {
            rb.velocity = new Vector2(0f, -7f);
        }
        //if no button is pressed the paddle stays in the same position
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }
}
