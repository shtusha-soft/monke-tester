using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeControl : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // good for input processing
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        //good for physics calculations
        Move();
    }

    void ProcessInputs(){
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, rb.velocity.y);
    }

}

