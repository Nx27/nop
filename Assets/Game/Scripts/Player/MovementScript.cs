using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
public class MovementScript : MonoBehaviour
{
    public double _MoveSpeed { get => MoveSpeed; set => MoveSpeed = value; }
    public bool _CanJump { get => CanJump; set => CanJump = value; }
    public bool _CanJumpTwice { get => CanJumpTwice; set => CanJumpTwice = value; }

    #region Code

    #region Fields

    private Rigidbody2D RB;
    private double MoveSpeed = 10;
    private bool CanJump;
    private bool CanJumpTwice;

    #endregion

    #region Function
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector2 Left = new((float)-MoveSpeed, RB.velocity.y);
            RB.AddForce(Left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector2 Right = new((float)MoveSpeed, RB.velocity.y);
            RB.AddForce(Right);
        }

        if (Input.GetKeyDown(KeyCode.Space) && CanJumpTwice)
        {
            Debug.Log("jumptwice");
            CanJumpTwice = false;
            Vector2 Jump = new(0, 10);  
            RB.AddForce(Jump, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.Space) && CanJump)
        {
            Debug.Log("jump");
            Vector2 Jump = new(0, 10);
            RB.AddForce(Jump, ForceMode2D.Impulse);
            CanJump = false;
            CanJumpTwice = true;
        }

        if (RB.velocity.magnitude > 0)
        {
            Vector2 Oppose = -RB.velocity;
            RB.AddForce(Oppose);
        }

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