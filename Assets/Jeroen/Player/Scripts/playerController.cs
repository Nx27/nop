using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float speed = 300f;
    private float jumpForce;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        jumpForce = jump();
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, jumpForce);
    }


    //Jump is janky en broken
    //TODO: Fix deze bullshit
    float jump()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            return 10f;
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f && IsGrounded())
        {
            return rb.velocity.y * 0.5f;
        }

        return rb.velocity.y;
    }

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
