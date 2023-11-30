using UnityEngine;

public class FireballController : MonoBehaviour
{
    public float lifetime = 3f;
    public GameObject owner;

    [SerializeField] public AudioSource humanDied;

    void Start()
    {
        // Destroy the fireball after a certain lifetime
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check for collisions with other objects (e.g., enemies)
        if (collision.CompareTag("enemy") && owner.CompareTag("fireball"))
        {
            // Handle enemy hit by player's fireball (e.g., destroy enemy)
            Destroy(collision.gameObject);
            Destroy(gameObject);
            humanDied.Play();

        }
        if (collision.CompareTag("projectile") && owner.CompareTag("fireball"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    // Set the owner of the fireball
    public void SetOwner(GameObject newOwner)
    {
        owner = newOwner;
    }
}
