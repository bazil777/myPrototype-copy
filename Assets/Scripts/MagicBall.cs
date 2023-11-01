using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBall : MonoBehaviour
{
    public float healthRestoration = 20f; // Adjust the amount as needed
    private PlayerHealth playerHealth; // Make sure this is properly assigned in the Inspector.

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Restore player's health and update the visual effect.
            playerHealth.RestoreHealth(healthRestoration);
            // Add visual effects like changing the color of the ball.
            GetComponent<Renderer>().material.color = Color.green; // Change to the desired color.
        }
    }
}
