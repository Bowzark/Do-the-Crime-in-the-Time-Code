using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelDisplay : MonoBehaviour
{
    public static string LevelName; // Declares a public variable of type string called LevelName
    public Text leveltext; // Declares a public variable of type Text called leveltext
    // Start is called before the first frame update
    void Start()
    {
        LevelName = SceneManager.GetActiveScene().name; // Gets the value of the current scene name and applies it to the "LevelName" variable
        leveltext.text = "Level: " + LevelName; // Displays the text "Level: " then the value of the variable "LevelName"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}