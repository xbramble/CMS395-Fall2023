using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class life : MonoBehaviour
{
    public int lives = 3;
    public int hits = 0;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject dragon;

    void Start()


    {

    }

    private void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("projectile"))
        {
            hits += 1;
            if(hits == 1)
            {
                heart1.SetActive(false);
            }
            else if(hits == 2)
            {
                heart2.SetActive(false);
            }
            else if(hits == 3)
            {
                heart3.SetActive(false);
            }
            else
            {
                dragon.SetActive(false);
                Debug.Log("game over");
            }
        }
       
    }
    public void GainLife()
    {
        if(hits == 2)
        {
            heart2.SetActive(true);
        }
        if(hits == 1)
        {
            heart1.SetActive(true);
        }
    }
}