using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform shootPoint;
    public float shootInterval = 1f;
    public float projectileSpeed = 5f;

    private float nextShootTime;

    private void Update()
    {
        if (Time.time > nextShootTime)
        {
            Shoot();
            nextShootTime = Time.time + shootInterval;
        }
    }

    private void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
        projectileRb.velocity = transform.forward * projectileSpeed;

        // Set the owner of the projectile to this enemy
        //ProjectileController projectileController = projectile.GetComponent<ProjectileController>();
        //if (projectileController != null)
        //{
         //   projectileController.SetOwner(gameObject);
        //}
    }
}
