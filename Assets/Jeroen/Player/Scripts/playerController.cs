using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float speed = 300f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement(new Vector2(Input.GetAxis("Horizontal"), jump()));
    }



    void movement(Vector2 direction) 
    {
        rb.velocity = direction * speed * Time.deltaTime;
    }

    float jump()
    {
        if (IsGrounded())
        {

        }
        return 0f;
    }

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
