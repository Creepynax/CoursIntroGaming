using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invertControls : MonoBehaviour
{
    private float invert;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            invert = Input.GetAxis("Horizontal");
            invert *= -1;
        }
    }
}
