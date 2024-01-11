using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    private float maxMovementSpeed = 10.0f;
    private float lerpSpeed = 0.5f;
    private float movement = 0.1f;
    Rigidbody2D body;
    [SerializeField]
    Transform GroundCheck;

    public float Movement { get => movement; set => movement = value; }

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetKey(KeyCode.A) ? -1 : Input.GetKey(KeyCode.D) ? 1 : 0;
        float vertical = Input.GetKey(KeyCode.S) ? -1 : Input.GetKey(KeyCode.W) ? 1 : 0;

        Vector2 vector2 = new Vector2(horizontal, vertical);
        Vector2 generalMovement = vector2 * movement;
        //Debug.Log(generalMovement);
        body.AddForce(generalMovement, ForceMode2D.Impulse);

        if (body.velocity.x > maxMovementSpeed)
        {
            body.velocity = new Vector2(maxMovementSpeed, body.velocity.y);
        }

        if (body.velocity.y > maxMovementSpeed)
        {
            body.velocity = new Vector2(body.velocity.x, maxMovementSpeed);
        }

        if (horizontal == 0)
        {
            body.velocity = new Vector2(0, body.velocity.y);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            body.velocity = new Vector2(body.velocity.x, 0);
        }
    }
    
}


