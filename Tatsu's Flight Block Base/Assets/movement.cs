using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovementScript : MonoBehaviour
{
    public float displacement;
    public Rigidbody2D dragon;
    Vector2 initial;
    public Animator animator;
    public float jump;
    Vector2 scroll;

    // Start is called before the first frame update
    void Start()
    {
        dragon = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        initial = dragon.transform.localPosition;
        scroll = dragon.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        scroll.x = scroll.x + 2f;
        dragon.MovePosition(scroll);

        if ((Input.GetKey(KeyCode.UpArrow)))
            if (initial.y <= 4)
                initial.y = initial.y + displacement;

        if ((Input.GetKey(KeyCode.DownArrow)))
            if (initial.y >= -4)
                initial.y = initial.y - displacement;

        dragon.MovePosition(initial);

        //if((Input.GetKey(KeyCode.Space)))
            //animator.SetTrigger("fireball");


    }
}