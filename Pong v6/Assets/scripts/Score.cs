using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text Scoreboard;
    public GameObject ball;

    private int Paddle1Score = 0;
    private int Paddle2Score = 0;
    
	// Use this for initialization
	void Start () {

        ball = GameObject.Find("Ball");
	}
	
	// Update is called once per frame
	void Update () {

        if (ball.transform.position.x >= 18.5f)
        {
            Paddle1Score ++;
        }
        if (ball.transform.position.x <= -18.5f)
        {
            Paddle2Score ++;
        }

        //updating the score on the scoreboard
        Scoreboard.text = Paddle1Score.ToString() + " - " + Paddle2Score.ToString();
        
	} 
}
