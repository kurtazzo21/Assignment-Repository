using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


	public void LoadLevel (string levelname)
    {
        //loads the scene named levelName
        SceneManager.LoadScene(levelname);
    }

    public void QuitGame()
    {
        //when the button quit is pressed the game closes
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void LoadNextLevel()
    {
        //when the button start is pressed level 1 is loaded
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Update () {

        if (Score.Paddle1Score == 3 || Score.Paddle2Score == 3)
        {
            SceneManager.LoadScene(2);
            Ball.NSpeed = -12f;
            Ball.PSpeed = 12f;
        }
        else if (Score.Paddle1Score == 8 || Score.Paddle2Score == 8)
        {
            SceneManager.LoadScene(3);
            Ball.NSpeed = -14f;
            Ball.PSpeed = 14f;
        }
        else if (Score.Paddle1Score == 15)
        {
            SceneManager.LoadScene(4);
        }
        else if (Score.Paddle2Score == 15)
        {
            SceneManager.LoadScene(5);
        }
    }

}
