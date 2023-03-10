using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(collision.gameObject.transform.localScale.x < 1f){
                collision.gameObject.transform.localScale *= 1.1f ;
            }
        }
    }
}
