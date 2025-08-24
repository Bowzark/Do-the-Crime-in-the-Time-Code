using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyDisplay : MonoBehaviour
{

    public Text difficultytext;
    private static string Difficulty; // Defines a private variable of type string called Difficulty
    // Start is called before the first frame update
    void Start()
    {
        Difficulty = DifficultyMenuController.Difficulty; // Gets the value of the Difficulty variable in the DifficultyMenuController Script
        difficultytext.text = "Difficulty : " + Difficulty; // Displays the string Difficulty then the value of the Difficulty String
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}