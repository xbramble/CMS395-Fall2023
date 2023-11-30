using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class life : MonoBehaviour
{
    public int maxLives = 3;
    public int currentLives;
    public GameObject[] heartSprites;

    private void Start()


    {
        currentLives = maxLives;
        UpdateHearts();


    }

    private void UpdateHearts()
    {
        for (int i = 0; i < heartSprites.Length; i++)
        {
            if (i < currentLives)
            {
                heartSprites[i].active = true; // Enable heart sprite
            }
            else
            {
                heartSprites[i].active = false; // Disable heart sprite
            }
        }
    }

    public void TakeDamage()
    {
        if (currentLives > 0)
        {
            currentLives--;
            UpdateHearts();
        }

        if (currentLives == 0)
        {
            // Game Over logic, e.g., restart level or show game over screen
            Debug.Log("Game Over");
        }
    }

    // Call this method when the player picks up a health power-up or achieves something that grants an extra life
    public void GainLife()
    {
        if (currentLives < maxLives)
        {
            currentLives++;
            UpdateHearts();
        }
    }

    // Example usage when the player is hit by an enemy
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("projectile"))
        {
            TakeDamage();
        }
    }
}