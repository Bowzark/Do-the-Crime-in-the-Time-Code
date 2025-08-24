using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelMenuController : MonoBehaviour
{
    public static string Level; // Declares a public variable of type string called "Level"
    public static bool AccessedLoadLevel; // Declares a public variable of type bool called "AccessedLoadLevel"
    // Start is called before the first frame update
    void Start()
    {
        AccessedLoadLevel = true; // Sets the value of the variable "AccessedLoadLevel" to true
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Level1()
    {
        Level = "Level 1"; // Sets the value of the variable "Level" to "Level 1"
        SceneManager.LoadScene("DifficultyMenu"); // Loads the Scene with the name "DifficultyMenu"
    }

    public void Level2()
    {
        Level = "Level 2"; // Sets the value of the variable "Level" to "Level 2"
        SceneManager.LoadScene("DifficultyMenu"); // Loads the Scene with the name "DifficultyMenu"
    }
    public void Level3()
    {
        Level = "Level 3"; // Sets the value of the variable "Level" to "Level 3"
        SceneManager.LoadScene("DifficultyMenu"); // Loads the Scene with the name "DifficultyMenu"
    }
}