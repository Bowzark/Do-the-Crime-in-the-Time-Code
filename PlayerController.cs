using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float walkspeed;
    public float runspeed;
    private float movementspeed;
    public float rotatespeed;
    public float maxcamerarotation = 85f;
    public float mincamrotation = 20f;
    private float camerarotationX = 0f;
    private float currentcamrotation = 0f;
    public float actualjumpspeed;
    private float jumpspeed;
    private bool isgrounded;
    private RigidBody rigid;
    public float h;
    public float v;
    public float y;
    public float x;
    
    // Animations

    private Animator PlayerAnim;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        rigid = GetComponent<RigidBody>();

        PlayerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Player Movement Input
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if(v > 0)
        {
            PlayerAnim.SetBool("IsRunning", true);
        }
        else
        {
            PlayerAnim.SetBool("IsRunning", false);
        }
        if(v < 0)
        {
            PlayerAnim.SetBool("IsRunningBackward", true);
        }
        else
        {
            PlayerAnim.SetBool("IsRunningBackward", false);
        }
        if(h > 0)
        {
            PlayerAnim.SetBool("IsStrafingRight", true);
        }
        else
        {
            PlayerAnim.SetBool("IsStrafingRight", false);
        }
        if(h < 0)
        {
            PlayerAnim.SetBool("IsStrafingLeft", true);
        }
        else
        {
            PlayerAnim.SetBool("IsStrafingLeft", false);
        }

        //Sprinting
        if (Input.GetKey(KeyCode.LeftShift) && v > 0 || Input.GetKey(KeyCode.LeftShift) && h > 0 || Input.GetKey(KeyCode.LeftShift) && h < 0)
        {
            movementspeed = runspeed;
        }
        else
        {
            movementspeed = walkspeed;
        }

        if (Input.GetKey(KeyCode.LeftShift) && v > 0)
        {
            PlayerAnim.SetBool("IsSprinting", true);
        }
        else
        {
            PlayerAnim.SetBool("IsSprinting", false);
        }

        //SprintingWhileStrafing
        if (Input.GetKey(KeyCode.LeftShift) && h > 0)
        {
            PlayerAnim.SetBool("IsStrafingRightFast", true);
        }
        else
        {
            PlayerAnim.SetBool("IsStrafingRightFast", false);
        }
        if (Input.GetKey(KeyCode.LeftShift) && h < 0)
        {
            PlayerAnim.SetBool("IsStrafingLeftFast", true);
        }
        else
        {
            PlayerAnim.SetBool("IsStrafingLeftFast", false);
        }

        // Player Rotation Left/Right Input

        y = Input.GetAxisRaw("Mouse X");

        /**Player Camera Rotation Up/Down Mouse Note:
        Cameras must be set to a tag of "maincamera".
        This code for camera movement will work for all cameras providing they all have the same tag.
        **/

        x = Input.GetAxisRaw("Mouse Y");
        float camrotate = x * Time.smoothDeltaTime * rotatespeed;

        currentcamrotation -= camrotate;
        currentcamrotation = Mathf.Clamp(currentcamrotation, -maxcamerarotation, mincamrotation);

        Camera.main.transform.localEulerAngles = new Vector3(currentcamrotation, 0, 0);

        //Main Menu Access
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void FixedUpdate()
    {
        // Player Movement

        Vector3 movement = new Vector3(h, 0f, v);
        movement = Vector3.Normalize(movement);
        movement = transform.TransformDirection(movement);
        rigid.MovePosition(transform.position + movement * Time.deltaTime * movementSpeed);

        // Player Rotation

        Vector3 playerrotation = new Vector3(0, y, 0) * rotatespeed * Time.smoothDeltaTime;

        rigid.MoveRotation(rigid.rotation * Quaternion.Euler(playerrotation));
    }
}