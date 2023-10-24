using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logistics : MonoBehaviour
{
    public Text BlueScore;
    public Text RedScore;
    int bluescore = 0;
    int redscore = 0;
    Ball ball;
    public AudioSource win;
    // Re-activate the ball, set its position back to the center, and reverse its direction to avoid rapid scoring on one side
    public void newBall () {
        gameObject.transform.parent.gameObject.SetActive(true);
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        ball.transform.position = new Vector2(0, 0);
        ball.direction.x = -ball.direction.x;
    }

    // Add score to the opposite player of the goal hit, place a new ball, then end the game completely if score reaches 5
    public void addScore(int input) {
        if (input == 1) {
            bluescore += 1;
            BlueScore.text = "0" + bluescore.ToString();
            newBall();
            if (bluescore == 5) {
                win.Play();
                BlueScore.text = "WIN!";
                gameObject.transform.parent.gameObject.SetActive(false);
            }
        } else if (input == 0) {
            redscore += 1;
            RedScore.text = "0" + redscore.ToString();
            newBall();
            if (redscore == 5) {
                win.Play();
                RedScore.text = "WIN!";
                gameObject.transform.parent.gameObject.SetActive(false);
            }
        }
    }
}
