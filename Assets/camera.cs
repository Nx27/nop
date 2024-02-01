using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform followTransform;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position = new Vector3(followTransform.position.x, followTransform.position.y, -1f);
    }
}
