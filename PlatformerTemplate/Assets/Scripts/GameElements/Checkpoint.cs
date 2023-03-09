using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform respawnPoint;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
            ActiveCheckpoint checkpoint = FindObjectOfType<ActiveCheckpoint>();
            if(checkpoint == null){
                GameObject go = new GameObject();
                checkpoint = go.AddComponent<ActiveCheckpoint>();  
                DontDestroyOnLoad(go);
            }
            checkpoint.checkpoint = respawnPoint.position;
        }
        
    }
}
