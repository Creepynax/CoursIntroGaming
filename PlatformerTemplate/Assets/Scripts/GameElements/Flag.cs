using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().FinishGame();
            ActiveCheckpoint checkpoint = FindObjectOfType<ActiveCheckpoint>();

            if(checkpoint != null){
            Destroy(checkpoint.gameObject);
            
            }
        }
    }

}
