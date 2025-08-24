using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyMenuController : MonoBehaviour
{
    public static string Difficulty; // Defines a public variable of type string called Difficulty
    private static string Level; // Defines a private variable of type string called Level
    private static bool AccessedLoadLevel; // Defines a private variable of type bool called AccessedLoadLevel
    private static bool ClickedOnStartGame; // Defines a private variable of type bool called ClickedOnStartGame
    // Start is called before the first Frame update
    void Start()
    {
        AccessedLoadLevel = LoadLevelMenuController.AccessedLoadLevel; // Gets the value of AccessedLoadLevel from the LoadLevelMenuController script
        ClickedOnStartGame = MainMenuMenuController.ClickedOnStartGame; // Gets the value of ClickedOnStartGame from the MainMenuMenuController script
        if (AccessedLoadLevel == true && ClickedOnStartGame == false) // If the player has accessed the Load Level Menu but has not clicked on start game
        {
            Level = LoadLevelMenuController.Level; // Gets the value of Level from the LoadLevelMenuController script
        }
        else
        {
            Level = "Level 1"; // Assigns the value "Level 1" to the variable Level
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Easy()
    {
        Difficulty = "Easy"; // Assigns the value "Easy" to the Difficulty variable
        if (Level == "Level 1") // If the level is "Level 1"
        {
            SceneManager.LoadScene("Level 1"); // Load the Scene called "Level 1"
        }
        if (Level == "Level 2") // If the level is "Level 2"
        {
            SceneManager.LoadScene("Level 2"); // Load the Scene called "Level 2
        }
        if (Level == "Level 3") // If the level is "Level 3"
        {
            SceneManager.LoadScene("Level 3"); // Load the Scene called "Level 3"
        }
    }

    public void Normal()
    {
        Difficulty = "Normal"; // Assigns the value "Normal" to the Difficulty variable
        if (Level == "Level 1") // If the level is "Level 1"
        {
            SceneManager.LoadScene("Level 1"); // Load the Scene called "Level 1"
        }
        if (Level == "Level 2") // If the level is "Level 2"
        {
            SceneManager.LoadScene("Level 2"); // Load the Scene called "Level 2
        }
        if (Level == "Level 3") // If the level is "Level 3"
        {
            SceneManager.LoadScene("Level 3"); // Load the Scene called "Level 3"
        }
    }

    public void Hard()
    {
        Difficulty = "Hard"; // Assigns the value "Hard" to the Difficulty variable
        if (Level == "Level 1") // If the level is "Level 1"
        {
            SceneManager.LoadScene("Level 1"); // Load the Scene called "Level 1"
        }
        if (Level == "Level 2") // If the level is "Level 2"
        {
            SceneManager.LoadScene("Level 2"); // Load the Scene called "Level 2
        }
        if (Level == "Level 3") // If the level is "Level 3"
        {
            SceneManager.LoadScene("Level 3"); // Load the Scene called "Level 3"
        }
    }
}