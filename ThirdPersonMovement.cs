using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 6.0f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Get input from the player
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        // Calculate the movement direction
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical);

        // Convert local movement to world space
        moveDirection = transform.TransformDirection(moveDirection);

        // Apply speed to the movement
        moveDirection *= speed;

        // Move the character using the CharacterController
        controller.Move(moveDirection * Time.deltaTime);
    }
}
