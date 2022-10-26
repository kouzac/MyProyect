using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


public class movement : MonoBehaviour
{
    private Animator _animation;
    [Range(1, 10)] public float velocidad; //Velocidad del jugador
    Rigidbody2D rb2d;
    SpriteRenderer spRd;
    bool isJumping = false; //Para comprobar si ya est� saltando
    [Range(1, 500)] public float potenciaSalto; //Potencia de salto del jugador
    void Start()
    {
        _animation = GetComponent<Animator>();
        
        //2. Capturo y asocio los componentes Rigidbody2D y Sprite Renderer del Jugador
        rb2d = GetComponent<Rigidbody2D>();
        spRd = GetComponent<SpriteRenderer>();

    }

    void FixedUpdate()
    {

        //3. Movimiento horizontal
        float movimientoH = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(movimientoH * velocidad, rb2d.velocity.y);
        _animation.SetFloat("correr",Mathf.Abs(movimientoH));
        //4. Sentido horizontal (para girar el render del jugador)
        if (movimientoH > 0)
        {
            spRd.flipX = false;
        }
        else if (movimientoH < 0)
        {
            spRd.flipX = true;
        }
        //Si pulso la tecla de salto (espacio) y no estaba saltando
        if (Input.GetButton("Jump") && !isJumping)
        {
            //Le aplico la fuerza de salto
            rb2d.AddForce(Vector2.up * potenciaSalto, ForceMode2D.Impulse);
            //Digo que est� saltando (para que no pueda volver a saltar)
            isJumping = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Si el jugador colisiona con un objeto con la etiqueta suelo
        if (other.gameObject.CompareTag("Suelo"))
        {
            //Digo que no est� saltando (para que pueda volver a saltar)
            isJumping = false;
            //Le quito la fuerza de salto remanente que tuviera
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
        }
    }
    
}
