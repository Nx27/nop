using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField]
    private float size = 5;
    [SerializeField]
    private Transform followTransform;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position = new Vector3(followTransform.position.x, followTransform.position.y, -1f);
    }

    private void FixedUpdate()
    {
        Camera.main.orthographicSize = size;
    }
}
