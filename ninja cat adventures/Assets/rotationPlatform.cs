using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationPlatform : MonoBehaviour
{
    int rotation = 0;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {

        body = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        body.angularVelocity = rotation;
    }

    // Update is called once per frame
    void Update()
    {
        rotation = 50;
    }
}
