using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Player_controler : MonoBehaviour
{
    public float horizontalInput;
    public float VerticalInput;
    public float speed = 10f;
    public int health = 5;

    private Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    Rigidbody2D rb2d;
    SpriteRenderer spRd;
    bool isJumping = false;
    [Range(1, 500)] public float potenciaSalto;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spRd = GetComponent<SpriteRenderer>();

    }
    

    // Start is called before the first frame update
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        //transform.position += Vector3.right*horizontalInput*speed*Time.deltaTime;
       // transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
       if (Input.GetButton("Jump") && !isJumping)
       {
           rb2d.AddForce(Vector2.up * potenciaSalto, ForceMode2D.Impulse);
           isJumping = true;
       }
        
        
        
    }
    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(speed * horizontalInput, _rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Suelo"))
        {
            isJumping = false;
           rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
           //_rb.AddForce(new Vector2(horizontalInput*speed, transform.position.y), ForceMode2D.Force);
        }
    }
}
