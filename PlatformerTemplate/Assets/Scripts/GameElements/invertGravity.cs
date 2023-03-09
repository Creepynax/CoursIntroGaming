using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invertGravity : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D playerRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();
            playerRigidbody.gravityScale *= -1;
        }
    }
}