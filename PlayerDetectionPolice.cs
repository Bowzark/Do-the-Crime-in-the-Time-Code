using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectionPolice : MonoBehaviour
{
    public GameObject PoliceModel; // Declares a public variable of type GameObject called "PoliceModel"
    private Animator PoliceAnim; // Declares a private variable of type Animator called "PoliceAnim"

    private int ScoreTakePercentage; // Declares a private variable of type integer called "ScoreTakePercentage"
    // Start is called before the first frame update
    void Start()
    {
        PoliceAnim = PoliceModel.GetComponent<Animator>(); // Gets the component called Animator from the "PoliceModel" GameObject
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") // If an object enters the trigger with the tag of "Player"
        {
            PoliceAnim.SetBool("isDetectedStealing", true); // Sets the value of the Bool variable inside the Animator component called "isDetectedStealing" to true
            ScoreTakePercentage = ScoreController.overallscore / 5; // Gets the value of the variable "overallscore" from the "ScoreController" script and divides it by 5
            ScoreController.overallscore = ScoreController.overallscore - ScoreTakePercentage; // Takes the value of the variable ScorePercentage from the variable "overallscore"
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") // If an object exits the trigger with the tag of "Player"
        {
            PoliceAnim.SetBool("isDetectedStealing", false); // Sets the value of the Bool variable inside the Animator component called "isDetectedStealing" to false
        }
    }
}