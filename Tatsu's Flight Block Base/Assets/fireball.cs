using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public float projectileLifetime = 3f;
    public GameObject owner;

    private void Start()
    {
        Destroy(gameObject, projectileLifetime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the projectile hits an enemy or another projectile
        if (other.CompareTag("enemy") && owner.CompareTag("fireball"))
        {
            Destroy(other.gameObject); // Destroy the enemy
            Destroy(gameObject); // Destroy the player's projectile
        }
        else if (other.CompareTag("Player") && owner.CompareTag("projectile"))
        {
            // Handle player hit by enemy projectile (e.g., decrease player health)
            // You can customize this part based on your game logic
            Destroy(gameObject); // Destroy the enemy's projectile
        }
    }

    // Set the owner of the projectile
    public void SetOwner(GameObject newOwner)
    {
        owner = newOwner;
    }
}