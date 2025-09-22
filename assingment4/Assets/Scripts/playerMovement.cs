using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    [SerializeField] float jumpForce = 5f;

    [SerializeField] private bool isGrounded = true; // Check for Jumping

    private void Start()
    {
      
      rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float moveH = Input.GetAxis("Horizontal"); // Horiztonal Movement
       
        rb.velocity = new Vector2(moveH * speed, rb.velocity.y);

            if (Input.GetKeyDown (KeyCode.Space) && isGrounded) // Jump Movement
        {
            Jump();
        }
    }
    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        isGrounded = false; // No Double Jump
        Debug.Log("JUMP TRIGGERED!");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach(ContactPoint2D contact in collision.contacts) // Resets Jump once player hits the ground
        {
            if (contact.normal.y > 0.5f)
            {
                isGrounded = true;
                break;
            
              
            }
        }

    }
}
