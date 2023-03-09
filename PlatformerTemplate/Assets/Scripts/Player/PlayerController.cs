using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigBod;

    [SerializeField]
    private LayerMask m_GroundLayer;

    [SerializeField]
    private float m_JumpForce;

    [SerializeField]
    private float m_MoveSpeed;

    private float _movement;
    private bool _isJump;

    private void Awake()
    {
        _rigBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.Raycast(transform.position, Vector2.down, 1f, m_GroundLayer))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _isJump = true;
            }
        }

        _movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        if (_isJump)
        {
            _isJump = false;

            _rigBod.AddForce(Vector2.up * m_JumpForce, ForceMode2D.Impulse);
        }

        _rigBod.velocity = new Vector2(m_MoveSpeed * _movement, _rigBod.velocity.y);

        // Ajouter une condition pour vérifier si la position X du joueur est supérieure à 200
        if(transform.position.y < -60)
        {
            //remet le joueur à sa position de départ
            transform.position = new Vector2(-9.09f, 3.71f);
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    public void Stop()
    {
        _rigBod.velocity = new Vector2(0, _rigBod.velocity.y);
        enabled = false;
    }
}
