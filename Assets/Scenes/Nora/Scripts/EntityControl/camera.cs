using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField]
    private float size = 5;
    [SerializeField]
    private Transform followTransform;

    private float scrollSpeed = 0.2f;
    public float ScrollSpeed { get => scrollSpeed; set => scrollSpeed = value; }

    void Start()
    {
        
    }
    void Update()
    {
        transform.position = new Vector3(followTransform.position.x, followTransform.position.y, -1f);
    }

    //    private void FixedUpdate()
    //    {
    //        if (scrollUp)
    //        {
    //            Camera.main.orthographicSize = size- scrollSpeed;
    //        }
    //        if (scrollDown)
    //        {
    //            Camera.main.orthographicSize = size+ scrollSpeed;
    //        }

    //    }
}
