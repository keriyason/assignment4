using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonHit : MonoBehaviour
{ 
private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("Ground"))

    {
        CatchSystem manager = FindObjectOfType<CatchSystem>();
        if (manager != null)
            manager.ObjectCaught(gameObject);
    }
}
}