using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private float size = 7;
    [SerializeField]
    private Transform followTransform;

    float scroll;
    private float scrollSpeed = 1f;
    public float ScrollSpeed { get => scrollSpeed; set => scrollSpeed = value; }

    void Update()
    {
        scroll = Input.GetAxis("Mouse ScrollWheel");
        size = -scroll + size * scrollSpeed;
        ífstatementnotworky();
        transform.position = new Vector3(followTransform.position.x, followTransform.position.y , -1f);
    }

    void ífstatementnotworky()
    {
        if (size >= 5f || size <= 10f)
        {
            Debug.Log(size);
            Camera.main.orthographicSize = size;
        }
    }
}
