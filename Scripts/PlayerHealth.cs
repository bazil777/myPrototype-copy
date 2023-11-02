using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f; // Adjust the maximum health as needed.
    private float currentHealth;

    private void Start()
    {
        // Initialize the player's current health to the maximum health when the game starts.
        currentHealth = maxHealth;
    }

    // Method to restore the player's health.
    public void RestoreHealth(float amount)
    {
        currentHealth += amount;

        // Ensure that the player's health does not exceed the maximum.
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);

        // You can add additional functionality here, such as updating a health bar UI.
    }

    // Method to damage the player (for future reference).
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;

        // You can implement game over logic here if the player's health reaches zero.
    }
}
