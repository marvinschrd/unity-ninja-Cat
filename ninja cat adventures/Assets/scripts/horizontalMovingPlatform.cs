using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalMovingPlatform : MonoBehaviour
{
    Vector2 direction = new Vector2(1, 0);
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        
        body = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        body.velocity = direction;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -0.6)
        {
            direction.x = 0.7f;
        }
        else if (transform.position.x > 0.7)
        {
            direction.x = -0.7f;
        }
    }
}
