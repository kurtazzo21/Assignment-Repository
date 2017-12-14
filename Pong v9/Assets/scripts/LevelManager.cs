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

}
