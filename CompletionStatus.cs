using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletionStatus : MonoBehaviour
{
    private static int ObjectiveScore; // Defines a private variable of type integer called ObjectiveScore
    private static int overallscore; // Defines a private variable of type integer called overallscore
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ObjectiveScore = ObjectiveDisplay.ObjectiveScore; // Gets the value of ObjectiveScore from the ObjectiveDisplay script
        overallscore = ScoreController.overallscore; // Gets the value of overallscore from the ScoreController script
        if (overallscore >= ObjectiveScore) // If the player's score is higher or equal to the Objective Score
        {
            SceneManager.LoadScene("LevelCompleteMenu"); // Loads te scene called LevelCompleteMenu
            Cursor.lockState = CursorLockMode.None; // Unlocks the cursor
            Cursor.visible = true; // Displays the cursor
        }
        else // if the player score is not higher or equal to the Objective Score then do nothing
        {
            
        }
    }
}