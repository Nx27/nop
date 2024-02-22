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
    private double MoveSpeed = 10;
    private bool CanJump;
    private bool CanJumpTwice;
    private double TimeToApex = 0.5f;
    private double JumpHeight = 25;

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
            Vector2 Left = new(transform.position.x - (float)MoveSpeed, transform.position.y);
            transform.position = Vector2.Lerp(transform.position, Left, Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector2 Right = new(transform.position.x + (float)MoveSpeed, transform.position.y);
            transform.position = Vector2.Lerp(transform.position, Right, Time.deltaTime);
        }

        //if (Input.GetKeyDown(KeyCode.Space) && CanJumpTwice)
        //{
        //    Debug.Log("jumptwice");
        //    CanJumpTwice = false;
        //    Vector2 JumpTwice = new(0, 100);
        //    transform.position = Vector2.Lerp(transform.position, JumpTwice, Time.deltaTime);
        //}
        //if (Input.GetKeyDown(KeyCode.Space) && CanJump)
        //{
        //    Debug.Log("jump");
        //    Vector2 Jump = new(0, 100);
        //    transform.position = Vector2.Lerp(transform.position, Jump, Time.deltaTime);
        //    CanJump = false;
        //    CanJumpTwice = true;
        //}

        if (Input.GetKeyDown(KeyCode.Space) && CanJump)
        {
            StartCoroutine(Jump());
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


    IEnumerator Jump()
    {
        float ElapsedTime = 0f;
        CanJump = false;
        RB.gravityScale = 0;
        Debug.Log("off");

        float initialVelocity = (float)JumpHeight / (float)TimeToApex;
        float initialY = transform.position.y;

        while (ElapsedTime < TimeToApex)
        {

            float verticalPosition = initialY + initialVelocity * ElapsedTime - 0.5f * Mathf.Abs(Physics2D.gravity.y) * Mathf.Pow(ElapsedTime, 2);


            Vector2 Jump = new(transform.position.x,verticalPosition);

            transform.position = Vector2.Lerp(transform.position, Jump, Time.deltaTime);

            yield return null;
            
            ElapsedTime += Time.deltaTime;
           
        }
        Debug.Log("On");
        Invoke("gravity", 0.1f);
    }

    void gravity()
    {
        RB.gravityScale = 1;
    }




}


#endregion

#endregion