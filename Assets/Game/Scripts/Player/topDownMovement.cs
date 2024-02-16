using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class topDownMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 3.0f;
    [SerializeField]
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 zoomies = new Vector2(horizontal, vertical);

        goZoomies(zoomies);
    }

    void goZoomies(Vector2 Pzoomies)
    {
        transform.Translate(Pzoomies * Time.deltaTime * moveSpeed, Space.World);
    }
}
