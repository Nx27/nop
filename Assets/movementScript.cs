using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    private float maxMovementSpeed = 10.0f;
    private float lerpSpeed = 0.5f;
    private float movement = 1;
    Rigidbody2D body;

    public float Movement { get => movement; set => movement = value; }

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 vector2 = new Vector2(horizontal, vertical).normalized;
        Vector2 UP = new Vector2(10, 0);
        Vector2 generalMovement = vector2 * movement;
        body.AddForce(generalMovement);
        
        if (horizontal < maxMovementSpeed)
        {
            horizontal = maxMovementSpeed;
        }
        if (vertical < maxMovementSpeed)
        {
            vertical = maxMovementSpeed;
        }

        
    }
}
