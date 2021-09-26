using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float xInput;
    float zInput;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * 200);

        }
        xInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector2.left * 200);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector2.right * 200);
        }
    }
}
