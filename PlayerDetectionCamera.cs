using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDetectionCamera : MonoBehaviour
{
    private RaycastHit vision; // Declares a private variable of type RaycastHit called "vision"
    public float rayLength; // Declares a public variable of type float called "rayLength"
    private bool isGrabbed; // Declares a private variable of type bool called "isGrabbed"
    private Rigidbody grabbedObject; // Declares a private variable of type Rigidbody called "grabbedObject"
    public Camera SecurityCamera; // Declares a public variable of type Camera called "SecurityCamera"
    public Transform Player; // Declares a public variable of type Transform called "Player"
    private bool isDetected; // Declares a private variable of type bool called "isDetected"
    // Start is called before the first frame update
    void Start()
    {
        rayLength = 10.0f; // How far the raycast goes
        isGrabbed = false; // Sets the value of the variable isGrabbed to false
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(SecurityCamera.transform.position, SecurityCamera.transform.forward, out vision, rayLength)) // If te Raycast as hit an object
        {
            if (vision.collider.tag == "Player") // If the Raycast has collided with an object with the tag of "Player"
            {
                SceneManager.LoadScene("GameOverMenu"); // Load the Scene with the name "GameOverMenu
                Cursor.lockState = CursorLockMode.None; // Unlock the Cursor
                Cursor.visible = true; // Display the Cursor
            }
            else // If the Raycast has collided with an object that doesn't have te tag of Player do nothing
            {

            }
        }
    }
}