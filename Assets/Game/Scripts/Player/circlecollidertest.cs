using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlecollidertest : MonoBehaviour
{
    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        GameObject other = collision.gameObject;
        if (other.layer == LayerMask.NameToLayer("Ground"))
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("jump");
            }
        }
    }
}
