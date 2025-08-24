using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public GameObject CivilianModel; // Declares a public variable of type GameObject called CivilianModel
    private Animator CivilianAnim; // Declares a private variable of type Animator called CivilianAnim
    // Start is called before the first frame update
    void Start()
    {
        CivilianAnim = CivilianModel.GetComponent<Animator>(); // Gets the component called Animator from the CivilianModel GameObject
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") // If an object enters the trigger with the tag of player
        {
            CivilianAnim.SetBool("IsDetected", true); // Sets the bool value of the variable inside the Animator called "IsDetected" to true
        }
    }
}