using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.PlayerLoop;
public class MovementScript : MonoBehaviour
{
    public double _MoveSpeed { get => MoveSpeed; set => MoveSpeed = value; }
    public bool _CanJump { get => CanJump; set => CanJump = value; }
    public bool _CanJumpTwice { get => CanJumpTwice; set => CanJumpTwice = value; }

    #region Code

    #region Fields

    private Rigidbody2D RB;
    private double MoveSpeed = 0.1;
    private bool CanJump;
    private bool CanJumpTwice;
    private double JumpHeight = 25;

    #endregion

    #region Function
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 movement = new(transform.position.x + horizontalInput, RB.gravityScale);
        RB.velocity = (movement);

        //if (Input.GetKeyDown(KeyCode.Space) && CanJumpTwice)
        //{
        //    Debug.Log("jumptwice");
        //    CanJumpTwice = false;
        //    Vector2 JumpTwice = new(RB.velocity.x, Jump);
        //    RB.AddForce(JumpTwice);
        //}
        //if (Input.GetKeyDown(KeyCode.Space) && CanJump)
        //{
        //    Debug.Log("jump");
        //    Vector2 JumpOnce = new(RB.velocity.x, Jump);
        //    RB.AddForce(JumpOnce);
        //    CanJump = false;
        //    CanJumpTwice = true;
        //}

    }


    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        GameObject other = collision.gameObject;
        if (other.layer == LayerMask.NameToLayer("Ground"))
        {
            CanJump = true;
            CanJumpTwice = false;
        }
    }
}


#endregion

#endregion