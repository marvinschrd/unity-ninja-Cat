using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalMovement : MonoBehaviour
{
    Vector2 direction = new Vector2(0, 1);
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
        if (transform.position.y < -1.2f)
        {
            direction.y = 0.7f;
        }
        else if (transform.position.y > 0.86f)
        {
            direction.y = -0.7f;
        }
    }
}
