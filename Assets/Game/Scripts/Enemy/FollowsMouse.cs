using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowsMouse : MonoBehaviour
{
    public float maxMoveSpeed = 10;
    public float smoothTime = 0.3f;

    Vector2 currentVelocity;

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.SmoothDamp(transform.position, mousePosition, ref currentVelocity, smoothTime, maxMoveSpeed);
    }
}
