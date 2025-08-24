using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static int overallscore; // Declares a public variable of type integer called "overallscore"
    public Text scoretext; // Declares a public variable of type Text called "scoretext"
    // Start is called before the first frame update
    void Start()
    {
        overallscore = 0; // Sets the value of overallscore to zero
        scoretext.text = "Score: " + overallscore; // Displays the text "Score: " then the value of the variable "overallscore"
    }
}