using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform firePoint;
    public float fireballSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Check for player input to shoot fireball
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootFireball();
        }
    }

    void ShootFireball()
    {
        // Instantiate a new fireball at the fire point position
        GameObject fireball = Instantiate(fireballPrefab, firePoint.position, Quaternion.identity);

        // Get the Rigidbody2D component of the fireball
        Rigidbody2D fireballRb = fireball.GetComponent<Rigidbody2D>();

        // Set the velocity of the fireball
        fireballRb.velocity = transform.right * fireballSpeed;

        // Optional: Set the fireball's owner (useful for handling collisions)
        fireball.GetComponent<FireballController>().SetOwner(gameObject);
    }
}

