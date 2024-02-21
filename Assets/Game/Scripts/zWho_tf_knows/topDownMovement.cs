using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class topDownMovement : MonoBehaviour
{
    public float _MoveSpeed { get => MoveSpeed; set => MoveSpeed = value; }


    #region Code

    #region Fields

    private float MoveSpeed = 3.0f;
    private Rigidbody2D Rb;

    #endregion

    #region Functions

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        Rb.gravityScale = 0;
    }

    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector2 Zoomies = new Vector2(Horizontal, Vertical);

        GoZoomies(Zoomies);
    }

    void GoZoomies(Vector2 Zoomies)
    {
        transform.Translate(Zoomies * Time.deltaTime * MoveSpeed, Space.World);
    }
}
#endregion

#endregion
