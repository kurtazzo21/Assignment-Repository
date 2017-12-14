using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text Scoreboard;

    public static int Paddle1Score = 0;
    public static int Paddle2Score = 0;
    
	
	// Update is called once per frame
	void Update () {

        //updating the score on the scoreboard
        Scoreboard.text = Paddle1Score.ToString() + " - " + Paddle2Score.ToString();
        
	} 
}
