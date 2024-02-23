using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    #region Fields
    [SerializeField] Rigidbody2D body;
    [SerializeField] Rigidbody2D target;
    [SerializeField] OnCollisionEnter2D onCollisionEnter;

    [SerializeField] float maxHealth = 10;
    private float health;
    [SerializeField] float speed;
    #endregion

    #region Code
    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.AddComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

}
