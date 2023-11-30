using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovementScript : MonoBehaviour
{
    public float displacement;
    public Rigidbody2D dragon;
    public float initial = 0;
    public Animator animator;
    public float jump;
    public float scrollSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        dragon = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        // initial = dragon.transform.position.y;
        float newPosition = transform.position.x + scrollSpeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        *   Movement Up and Down
        */

        float newPosition = transform.position.x + scrollSpeed * Time.deltaTime;
        //transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);

        if ((Input.GetKey(KeyCode.W)))
            if (initial <= 3)
                initial = initial + displacement;

        if ((Input.GetKey(KeyCode.S)))
            if (initial >= -3.6)
                initial = initial - displacement;

        //dragon.MovePosition(initial);
        transform.position = new Vector3(newPosition, initial, transform.position.z);
        //if((Input.GetKey(KeyCode.Space)))
        //animator.SetTrigger("fireball");

        /*
        *   Fireball shooting
        */

        // Reset Fireball animation variable
        animator.SetFloat("IsShooting", 0);

        if ((Input.GetKey(KeyCode.Space)))
            animator.SetFloat("IsShooting", 1);
        
        /*
        *   Getting Hurt
        */

        // Reset hurt animation variable
        animator.SetFloat("IsHurt", 0);

        if ((Input.GetKey(KeyCode.G)))
            animator.SetFloat("IsHurt", 1);

        /*
        *   Dying
        */

        // Reset dying animation variable
        animator.SetFloat("IsDead", 0);

        if ((Input.GetKey(KeyCode.H)))
            animator.SetFloat("IsDead", 1);

    }
    
}