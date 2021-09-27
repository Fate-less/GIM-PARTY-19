using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float xInput;
    float zInput;
    public float speed;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 500);

        }
        xInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector2.left * 500);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector2.right * 500);
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
