using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D _rigBod;

    [SerializeField]
    private LayerMask m_GroundLayer;

    [SerializeField]
    private int m_HauteutMin;

    [SerializeField]
    private float m_JumpForce;

    [SerializeField]
    private float m_xDepart;

    [SerializeField]
    private float m_YDepart;

    [SerializeField]
    private float m_MoveSpeed;

    private float _movement;
    private bool _isJump;

    public float movementMultiplicator = 1;

    private void Awake()
    {
        _rigBod = GetComponent<Rigidbody2D>();
    }

    private void Start(){
        ActiveCheckpoint checkpoint = FindObjectOfType<ActiveCheckpoint>();
        if(checkpoint != null){
            transform.position = checkpoint.checkpoint;
        }
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

        _rigBod.velocity = new Vector2(m_MoveSpeed * _movement * movementMultiplicator, _rigBod.velocity.y);


        // Ajouter une condition pour vérifier si la position X du joueur est superieur à -60
        if(transform.position.y < m_HauteutMin)
        {
            //remet le joueur à sa position de départ
            transform.position = new Vector2(m_xDepart, m_YDepart);
            FindObjectOfType<GameManager>().GameOver();
        }

        //rotate le joueur en fonction de ou il se dirige
        if(_movement > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if(_movement < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }


    public void Stop()
    {
        _rigBod.velocity = new Vector2(0, _rigBod.velocity.y);
        enabled = false;
    }
}
