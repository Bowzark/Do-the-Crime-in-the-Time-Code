using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuMenuController : MonoBehaviour
{
    public static bool ClickedOnStartGame; // Declares a public variable of type bool called "ClickedOnStartGame"
    // Start is called before the first frame update
    void Start()
    {
        ClickedOnStartGame = false; // Sets the value of the variable "ClickedOnStartGame" to false
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        ClickedOnStartGame = true; // Sets the value of the variable "ClickedOnStartGame" to true
        SceneManager.LoadScene("DifficultyMenu"); // Loads the scene with the name "DifficultyMenu"
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("LoadLevelMenu"); // Loads the scene with the name "LoadLevelMenu"
    }

    public void ExitGame()
    {
        Application.Quit(); // Closes the application
    }
}