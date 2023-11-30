using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float lifetime = 3f;
    public GameObject owner;

    void Start()
    {
        // Destroy the projectile after a certain lifetime
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check for collisions with other objects (e.g., player)
        if (collision.CompareTag("Player") && owner.CompareTag("EnemyProjectile"))
        {
            // Handle player hit by enemy projectile (e.g., decrease player health)
            // You can customize this part based on your game logic
            Destroy(gameObject);
        }
    }

    // Set the owner of the projectile
    public void SetOwner(GameObject newOwner)
    {
        owner = newOwner;
    }
}
