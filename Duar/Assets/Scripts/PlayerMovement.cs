using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject gameOver;
    public float moveSpeed = 1f;
    public float jumpSpeed = 1;
    public vectorValue startingPosition;
    public Animator animator;
    Vector2 move;
    [SerializeField] private LayerMask layerMask;

    void FixedUpdate()
    {
        
    }

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Horizontal", movement);
        if (movement == 0)
        {
            animator.SetBool("isMoving", false);
        }
        else
        {
            animator.SetBool("isMoving", true);
        }
        transform.position = transform.position + new Vector3(movement * moveSpeed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(rb.velocity.y) < 1)
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
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
