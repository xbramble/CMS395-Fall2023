using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddle : MonoBehaviour
{
    public float displacement;
    Rigidbody2D paddle;
    Vector2 initial;

    // Get physics component and assign starting position
    void Start()
    {
        paddle = GetComponent<Rigidbody2D>();
        initial = paddle.transform.localPosition;
    }

    // Check for left, left diagonal, right, right diagonal, and up and down movements while keeping the paddle in bounds
    void Update()
    {
        if ((Input.GetKey(KeyCode.L)) && initial.x < 10.75) {
            initial.x = initial.x + displacement;
            if ((Input.GetKey(KeyCode.I)) && initial.y < 4) {
                initial.y = initial.y + displacement;
            } else if ((Input.GetKey(KeyCode.K)) && initial.y > -4) {
                initial.y = initial.y - displacement;
            }
        } else if ((Input.GetKey(KeyCode.J)) && initial.x > 6) {
            initial.x = initial.x - displacement;
            if ((Input.GetKey(KeyCode.I)) && initial.y < 4) {
                initial.y = initial.y + displacement;
            } else if ((Input.GetKey(KeyCode.K)) && initial.y > -4) {
                initial.y = initial.y - displacement;
            }
        } else if ((Input.GetKey(KeyCode.I)) && initial.y < 4) {
            initial.y = initial.y + displacement;
        } else if ((Input.GetKey(KeyCode.K)) && initial.y > -4) {
            initial.y = initial.y - displacement;
        }

        paddle.MovePosition(initial);
    }
}