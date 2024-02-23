using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    #region Fields
    [SerializeField] float maxHealth = 10;
    [SerializeField] float speed = 1;

    private float health;

    #endregion

    #region Code

    void Start()
    {
        body = gameObject.AddComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       


    }

    #endregion

}
