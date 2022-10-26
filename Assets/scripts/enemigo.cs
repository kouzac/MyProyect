using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public float speed;
   [SerializeField] public float vida;
   [SerializeField] private GameObject efectoMuerte;
    
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void tomarDaño(float daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    //private void Muerte()
    //{
   //     Instantiate(efectoMuerte, transform.position, Quaternion.identity);
       //     Destroy(gameObject);
   // }
}
