using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pickup : MonoBehaviour
{
    public GameObject scorepanel; // Declares a public variable of type GameObject called "ScorePanel"
    private ScoreController scorec; // Declares a private variable of type ScoreController called "scorec"

    public GameObject PickupPanel; // Declares a public variable of type GameObject called "PickupPanel"

    private bool pickUpAllowed; // Declares a private variable of type bool called "pickUpAllowed"

    // Start is called before the first frame update
    void Start()
    {
        scorec = scorepanel.GetComponent<ScoreController>(); // Gets the component "ScoreController" from the "scorepanel"
    }

    void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.F)) // If the variable pickUpAllowed is true and the "F" key has been pressed
        {
            Destroy(gameObject); // Delete the pickup object
            PickupPanel.gameObject.SetActive(false); // Disable the PickupPanel
            scorec.calcscore(point); // Gets the value of poitns from the object being picked up and adds it onto the player's current score
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") // If an object enters the trigger with the tag of "Player"
        {
            PickupPanel.gameObject.SetActive(true); // Enable the PickupPanel
            pickUpAllowed = true; // Sets the value of variable "pickUpAllowed" to true
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") // If an object exits the trigger with the tag of "Player"
        {
            PickupPanel.gameObject.SetActive(false); // Disables the PickupPanel
            pickUpAllowed = false; // Sets the value of variable pickUpAllowed to false
        }
    }
}