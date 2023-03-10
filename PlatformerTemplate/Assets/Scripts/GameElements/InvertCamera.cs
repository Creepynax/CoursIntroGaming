using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertCamera : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Camera.main.orthographicSize *= -1;
        }
    }
}

