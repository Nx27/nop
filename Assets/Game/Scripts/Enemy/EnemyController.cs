using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    #region Fields
    [SerializeField] double MaxHealth = 10;
    [SerializeField] double Speed = 1;
    
    private float Health;

    #endregion

    #region Code

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision) {
        GameObject other = collision.gameObject;
        Debug.Log("fml");
    }

}

    #endregion


