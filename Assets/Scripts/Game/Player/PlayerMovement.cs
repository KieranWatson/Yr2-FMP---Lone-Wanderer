using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform feet;
    public LayerMask groundLayers;

    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    float mx;

    public Rigidbody2D rb;

    // Update is called once per frame
    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * moveSpeed, rb.velocity.y);

        rb.velocity = movement;
    }

    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;
    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, .5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }

        return false;
    }
}
