using System.Collections;
using System.Collections.Generic;
using UnityEngine;
Using UnityEngine.SceneManagement;

public class CurrentLevelStatus : MonoBehaviour
{
    public static string Level; // Defines a public variable of type string called Level
    // Start is called before the first frame update
    void Start()
    {
        Level = SceneManager.GetActiveScene().name; //Gets the current scene name
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}