using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldPlayerMovement : MonoBehaviour
 {
    public Rigidbody2D rb;
    public GameObject gameOver;
    public float moveSpeed = 5f;
    Vector2 movement;
    public vectorValue startingPosition;
    public Animator animator;
    public AudioSource theme;

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Debug.Log("Player spawn");
        theme.Play();
        Debug.Log("Now playing theme");
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Enemy")
        {
            Collider2D.Destroy(gameObject);
            Debug.Log("Game Over");
            gameOver.SetActive(true);
        }
    }


}


