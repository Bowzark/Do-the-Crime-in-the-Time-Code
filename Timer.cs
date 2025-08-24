using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer: MonoBehaviour
{
    private float currentTime = 0f; // Declares a private variable of type float called "currentTime"
    private float startingTime; // Declares a private variable of type float called "startingTime"
    private static string Difficulty; // Declares a private variable of type string called "Difficulty"
    private static string Level; // Declares a private variable of type string called "Level"
    public Text TimerText; // Declares a public variable of type Text called "TimerText"
    // Start is called before the first frame update
    void Start()
    {
        Difficulty = DifficultyMenuController.Difficulty; // Gets the value of the variable "Difficulty" from the "DifficultyMenuController" script
        Level = LevelDisplay.LevelName; // Gets the value of the variable "LevelName" from the "LevelDisplay" script

        if(Difficulty == "Easy" && Level == "Level 1") // If the Difficulty is set to easy and the level selected is Level 1
        {
            startingTme = 180f; // Set the value of "startingTime" to 180 seconds
        }

        if(Difficulty == "Easy" && Level == "Level 2") // If the Difficulty is set to easy and the level selected is Level 2
        {
            startingTme = 180f; // Set the value of "startingTime" to 180 seconds
        }

        if(Difficulty == "Easy" && Level == "Level 3") // If the Difficulty is set to easy and the level selected is Level 3
        {
            startingTme = 180f; // Set the value of "startingTime" to 180 seconds
        }

        if(Difficulty == "Normal" && Level == "Level 1") // If the Difficulty is set to normal and the level selected is Level 1
        {
            startingTme = 120f; // Set the value of "startingTime" to 120 seconds
        }

        if(Difficulty == "Normal" && Level == "Level 2") // If the Difficulty is set to normal and the level selected is Level 2
        {
            startingTme = 120f; // Set the value of "startingTime" to 120 seconds
        }

        if(Difficulty == "Normal" && Level == "Level 3") // If the Difficulty is set to normal and the level selected is Level 3
        {
            startingTme = 120f; // Set the value of "startingTime" to 120 seconds
        }

        if(Difficulty == "Hard" && Level == "Level 1") // If the Difficulty is set to hard and the level selected is Level 1
        {
            startingTme = 60f; // Set the value of "startingTime" to 60 seconds
        }

        if(Difficulty == "Hard" && Level == "Level 2") // If the Difficulty is set to hard and the level selected is Level 2
        {
            startingTme = 60f; // Set the value of "startingTime" to 60 seconds
        }

        if(Difficulty == "Hard" && Level == "Level 3") // If the Difficulty is set to hard and the level selected is Level 3
        {
            startingTme = 60f; // Set the value of "startingTime" to 60 seconds
        }
        currentTime = startingTime; // Set the value of the variable "currentTime" to the value of the variable "startingTime"
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime; // Takes away the value of 1 from te "currentTime" variable every second
        TimerText.text = "Time Left: " + currentTime.ToString ("0"); // Displays the text "Time Left: " then the value of "currentTime" that has been converted to string

        if (currentTime <= 0) // If the time is equal to or lower than zero
        {
            SceneManager.LoadScene("GameOverMenu"); // Load the scene with the name "GameOverMenu"
            Cursor.lockState = CursorLockMode.None; // Unlock the cursor
            Cursor.visible = true; // Display the cursor
        }
    }
}