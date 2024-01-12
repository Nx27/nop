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
    [SerializeField] private float jumpForce;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = (new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime,jumpForce));
        }
        rb.velocity = (new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f));
    }
}
