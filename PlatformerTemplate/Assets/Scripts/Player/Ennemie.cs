using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemie : MonoBehaviour
{


    [SerializeField]
    private Transform m_Target;

    [SerializeField]
    private float m_Speed;

    // Start is called before the first frame update

    // Update is called once per frame

    void Update()
    {
        Vector3 direction = (m_Target.position-transform.position).normalized;
        transform.position += (direction * m_Speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
