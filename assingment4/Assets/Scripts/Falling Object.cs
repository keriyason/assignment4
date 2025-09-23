using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CatchSystem manager = FindObjectOfType<CatchSystem>();
            if (manager != null)
            {
                manager.ObjectCaught(gameObject); // Updates Score
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Hit the ground! Destroying object.");

            Destroy(gameObject);
        }
        
    }
}
