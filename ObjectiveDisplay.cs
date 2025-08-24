using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectiveDisplay : MonoBehaviour
{
    private string SceneName; // Declares a private variable of type string called "SceneName"
    public static int ObjectiveScore; // Declares a public variable of type integer called "ObjectiveScore"
    public Text objectivetext; // Declares a public variable of type text called "objectivetext"
    private static string Difficulty; // Declares a private variable of type string called "Difficulty"
    // Start is called before the first frame update
    void Start()
    {
        Difficulty = DifficultyMenuController.Difficulty; // Gets the value of "Difficulty" from the "DifficultyMenuController"
        SceneName = SceneManager.GetActiveScene().name; // Gets the value fo the current scene name
        if (SceneName == "Level 1") // If the Scene Name is equal to "Level 1"
        {
            ObjectiveScore = 1000; // Sets the Objective Score to "1000"
        }
        if (SceneName == "Level 2") // If the Scene Name is equal to "Level 2"
        {
            ObjectiveScore = 15000; // Sets the Objective Score to "15000"
        }
        if (SceneName == "Level 3") // If the Scene Name is equal to "Level 3"
        {
            ObjectiveScore = 1000; // Sets the Objective Score to "1000"
        }
        objectivetext.text = "Objective: Collect " + ObjectiveScore + " Score before the timer runs out"; // Displays the Objective Text and the value of the "ObjectiveScore"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}