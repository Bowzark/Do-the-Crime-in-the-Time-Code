using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuController : MonoBehaviour
{
    private static string Level; // Defines a private variable of type string called Level
    // Start is called before the first frame update
    void Start()
    {
        Level = CurrentLevelStatus.Level; // Gets the value of Level from the CurrentLevelStatus script
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartLevel()
    {
        if (Level == "Level 1") // If the level is "Level 1"
        {
            SceneManager.LoadScene("Level 1"); // Load the Scene called "Level 1"
        }
        if (Level == "Level 2") // If the level is "Level 2"
        {
            SceneManager.LoadScene("Level 2"); // Load the Scene called "Level 2"
        }
        if (Level == "Level 3") // If the level is "Level 3"
        {
            SceneManager.LoadScene("Level 3"); // Load the Scene called "Level 3"
        }
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Load the Scene called "MainMenu"
    }
}