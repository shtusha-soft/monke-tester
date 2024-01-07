using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeControl : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce = 10f; // Jump force
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    private bool isJumping = false; // Flag to check if we should jump

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        // Check for jump input
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            isJumping = true;
        }

        moveDirection = new Vector2(moveX, 0).normalized; // Removed vertical movement for walking
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, rb.velocity.y);

        // If jump is triggered, add vertical force
        if (isJumping)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isJumping = false;
        }
    }

    // Check if the character is on the ground
    private bool IsGrounded()
    {
        // You can implement your grounded logic here.
        // For example, use a Raycast or check collision with a ground layer.
        return true; // Placeholder: replace with actual grounded check
    }
}