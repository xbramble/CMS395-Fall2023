using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovementScript : MonoBehaviour
{
    public float displacement;
    public Rigidbody2D dragon;
    public float initial = 0;
    public Animator animator;
    public float jump;
    public float scrollSpeed = 2f;

    [SerializeField] private AudioSource dragonInjured;

    // Start is called before the first frame update
    void Start()
    {
        dragon = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        //initial = dragon.transform.localPosition;
        float newPosition = transform.position.x + scrollSpeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        float newPosition = transform.position.x + scrollSpeed * Time.deltaTime;
        //transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);

        if ((Input.GetKey(KeyCode.UpArrow)))
            if (initial <= 5)
                initial = initial + displacement;

        if ((Input.GetKey(KeyCode.DownArrow)))
            if (initial >= -5)
                initial = initial - displacement;

        //dragon.MovePosition(initial);
        transform.position = new Vector3(newPosition, initial, transform.position.z);
        //if((Input.GetKey(KeyCode.Space)))
        //animator.SetTrigger("fireball");

    }
    
}