using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the power-up is collected by the player
        if (collision.CompareTag("dragon"))
        {
            // Call the GainLife method on the PlayerHealth script
            collision.GetComponent<life>().GainLife();

            // Destroy the power-up
            Destroy(gameObject);
        }
    }
}