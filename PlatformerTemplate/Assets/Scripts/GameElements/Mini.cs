using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(collision.gameObject.transform.localScale.x > 0.1f){
                collision.gameObject.transform.localScale *= 0.9f ;
            }
        }
    }
}
