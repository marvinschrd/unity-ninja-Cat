using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingBlock : MonoBehaviour
{
    public GameObject Cat;
    
    public playerHealth PlayerHealth;
    public int blockDamage = 1;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        Cat = GameObject.Find("Player");
        PlayerHealth = Cat.GetComponent<playerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        body.gravityScale = 1;
    }
    //public void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag.Equals("Player") == true)
    //    {
    //        PlayerHealth.TakeDamage(3);

    //    }
    //}
}
