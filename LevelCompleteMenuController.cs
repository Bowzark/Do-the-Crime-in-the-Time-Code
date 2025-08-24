using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteMenuController : MonoBehaviour
{
    private static string Level; // Defines a variable of type string called Level

    // Start is called before the first frame update
    void Start()
    {
        Level = CurrentLevelStatus.Level; // Gets the value of Level from the CurrentLevelStatus script
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextLevel()
    {
        if (Level == "Level 1") // If Level is "Level 1"
        {
            SceneManager.LoadScene("Level 2"); // Load the scene called "Level 2"
        }
        if (Level == "Level 2") // If Level is "Level 2"
        {
            SceneManager.LoadScene("Level 3"); // Load the scene called "Level 3"
        }
        if (Level == "Level 3") // If Level is "Level 3"
        {
            SceneManager.LoadScene("Level 1"); // Load the scene called "Level 1"
        }
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Load the scene called "MainMenu"
    }
}