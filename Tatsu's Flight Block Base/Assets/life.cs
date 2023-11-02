using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class life : MonoBehaviour
{
    public float scrollSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        float newPosition = transform.position.x + scrollSpeed * Time.deltaTime;
    }

// Update is called once per frame
    void Update()
    {
        float newPosition = transform.position.x + scrollSpeed * Time.deltaTime;
        transform.position = new Vector3(newPosition, 1.7834f, transform.position.z);
}
}
