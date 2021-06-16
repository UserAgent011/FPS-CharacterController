using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
public class PlayerMovement : MonoBehaviour
{
    public static CharacterController controller;
    private static float speed = 6f;
    //<summary>
    // Add A Character Controller To Player
    //</summary>
    Vector3 moveDireciton = Vector3.zero;
    private static float gravity = 20f;
    private static float jump = 8f;
    void Start()
    {
        controller = GetComponent<CharacterController>(); 
    }
    void Update()
    {
        if (controller.isGrounded)
        {
            moveDireciton = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moveDireciton *= speed;
            moveDireciton = transform.TransformDirection(moveDireciton);
            if (Input.GetKey(KeyCode.Space))
            {
                moveDireciton.y = jump; 
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 12f; 
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 6f;
        }
        moveDireciton.y -= gravity * Time.deltaTime;
        controller.Move(moveDireciton * Time.deltaTime); 
    }
}
