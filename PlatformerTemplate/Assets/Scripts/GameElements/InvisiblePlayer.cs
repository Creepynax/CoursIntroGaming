using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisiblePlayer : MonoBehaviour
{
    public Renderer characterRenderer;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (characterRenderer.enabled == false)
            {
                characterRenderer.enabled = true;
            }
            else 
            {
                characterRenderer.enabled = false;
            }
        }
    }
}
