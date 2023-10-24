using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Vector2 direction;
    public Logistics score;
    public AudioSource bounce;
    public AudioSource goal;
    // Set the rigidbody, the direction of movement, and set the score object for calling its functions later
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized; //(1, 1)
        score = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logistics>();
    }

    // Only the velocity calculation is needed here
    void Update()
    {
        rb.velocity = direction * speed;
    }

    // Check which part of the game the ball hits and either play the bounce or goal sound along with updating score
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle")) {
            direction.x = -direction.x;
            bounce.Play();
        } else if (collision.gameObject.CompareTag("Border")) {
            direction.y = -direction.y;
            bounce.Play();
        } else if (collision.gameObject.CompareTag("BlueGoal")) {
            goal.Play();
            score.addScore(0);
        } else if (collision.gameObject.CompareTag("RedGoal")) {
            goal.Play();
            score.addScore(1);
        }
    }
}
