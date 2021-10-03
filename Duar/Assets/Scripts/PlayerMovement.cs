using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public float jumpSpeed = 5f;
    Vector2 movement;
    public vectorValue startingPosition;
    public Animator animator;
    private CapsuleCollider2D box;
    [SerializeField] private LayerMask layerMask;

    void FixedUpdate()
    {
        
    }

    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = transform.GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("space") && IsGrounded())
        {
            float jumpVelocity = jumpSpeed;
            rb.velocity = Vector2.up * jumpVelocity;
        }
        Movement();

        if (IsGrounded())
        {
            if(rb.velocity.x != 0)
            {
                animator.SetFloat("Horizontal", rb.velocity.x);
                animator.SetFloat("Speed", rb.velocity.sqrMagnitude);
            } else
            {
                animator.SetFloat("Horizontal", rb.velocity.x * 0);
                animator.SetFloat("Speed", rb.velocity.sqrMagnitude * 0);
            }
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0f, Vector2.down, .1f, layerMask);
        return raycast.collider != null;
    }
    private void Movement()
    {
        float speed = moveSpeed;
        if(Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        } else
        {
            if(Input.GetKey("right"))
            {
                rb.velocity = new Vector2(+speed, rb.velocity.y);
            } else { }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Enemy")
        {
            Collider2D.Destroy(gameObject);
            gameOver.SetActive(true);
        }
    }

    
}
