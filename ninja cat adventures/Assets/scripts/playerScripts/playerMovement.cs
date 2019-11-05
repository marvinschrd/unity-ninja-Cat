using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public playerHealth playerHealth;
    public fallingBlock fallingBlock;
  //  public Animator animator;
    private Rigidbody2D body;
    float HorizontalMove;
    bool facingRight = true;
    bool facingLeft = false;
    int damage = 0;
   
    Vector2 direction;
    Vector2 position;

    [SerializeField]
    private float speed = 2;

    //PlayerHealth playerHealth;

    bool canJump = false;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        if (body != null)
        {
            Debug.Log("Body founded!");
        }
        else
        {
            Debug.Log("No nody");
        }

        playerHealth = GetComponent<playerHealth>();
    }

    void FixedUpdate()
    {
        body.velocity = direction;
    }

    // Update is called once per frame
    void Update()
    {
        
        
            direction = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
        HorizontalMove = Input.GetAxis("Horizontal") * speed;
           // animator.SetFloat("speed", Mathf.Abs(HorizontalMove));


        if (Input.GetAxis("Jump") > 0.1f && canJump== true)
        {
            Debug.Log("ici");
            direction.y += 2;

          //  animator.SetBool("isJumping", true);
            canJump = false;
           
        }

        if (HorizontalMove <0 && facingLeft == false )
        {
            facingLeft = true;
            facingRight = false;
           // animator.transform.Rotate(0, 180, 0);
        }

        if (HorizontalMove > 0 && facingRight == false)
        {
            facingRight = true;
            facingLeft = false;
           // animator.transform.Rotate(0, 180, 0);
        }

        position = new Vector2(-4.12f, -0.91f);

        if (transform.position.y < -3.30f)
        {
            body.MovePosition(position);
            playerHealth.outOfMap = true;
        }

        //void jump()
        //{
        //    if (Input.GetAxis("Jump") > 0.1f&& canJump == true)
        //    {
        //        direction.y += 2;
        //    }
        //};
    }

    void OnCollisionStay2D(Collision2D other)
    {
        canJump = true;
       // animator.SetBool("isJumping", false);
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Trap") == true)
        {
           // damage = fallingBlock.blockDamage;
            playerHealth.TakeDamage(1);
            body.MovePosition(position);

        }
        if (collision.gameObject.tag.Equals("chest") == true)
        {
            Destroy(gameObject);
        }
    }
}
