using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvingPlatform : MonoBehaviour
{
    public Transform posA, posB;
    public float speed;
    Vector3 tragetPos;

    private void Start(){
        tragetPos = posB.position;
    }

    private void Update(){

        if (Vector2.Distance(transform.position, posA.position) < 0.05f){
            
            tragetPos = posB.position;
        }

        if (Vector2.Distance(transform.position, posB.position) < 0.05f){

            tragetPos = posA.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, tragetPos, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            collision.transform.parent = this.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            collision.transform.parent = null;
        }
    }
}
