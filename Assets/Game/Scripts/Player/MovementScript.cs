using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovementScript : MonoBehaviour
{
    public double _MoveSpeed { get => MoveSpeed; set => MoveSpeed = value; }



    private Rigidbody2D RB;
    private Vector2 Movement;
    private double MoveSpeed = 1;
    private GameObject GroundCheck, HeadCheck, FrontCheck;
    private int GroundLayer;


    RaycastHit hit;
    void Start()
    {
        GroundCheck = GameObject.Find("GroundCheck");
        HeadCheck = GameObject.Find("HeadCheck");
        FrontCheck = GameObject.Find("FrontCheck");
        RB = GetComponent<Rigidbody2D>();
        GroundLayer = (1 << 6);
    }

    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        double HorizontalMovement = Horizontal * 0.1 * MoveSpeed;
        Movement = new((float)HorizontalMovement, 0);
        transform.Translate(Movement, Space.Self);

    }


    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        GameObject other = collision.gameObject;
        if (other.layer == LayerMask.NameToLayer("Ground"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("jump");
            }
        }
    }
}
