using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform shootPoint;
    public float shootInterval = 2f;
    public float projectileSpeed = 5f;

    private float nextShootTime;

    void Update()
    {
        // Check if it's time to shoot
        if (Time.time > nextShootTime)
        {
            ShootProjectile();
            // Set the next shoot time
            nextShootTime = Time.time + shootInterval;
        }
    }

    void ShootProjectile()
    {
        // Instantiate a new projectile at the shoot point position
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);

        // Get the Rigidbody2D component of the projectile
        Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();

        // Set the velocity of the projectile
        projectileRb.velocity = transform.right * projectileSpeed;

        // Optional: Set the projectile's owner (useful for handling collisions)
        projectile.GetComponent<ProjectileController>().SetOwner(gameObject);
    }
}
