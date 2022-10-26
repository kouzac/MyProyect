using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float daño;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * velocidad* Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemigo"))
        {
            other.GetComponent<enemigo>().tomarDaño(daño);
            Destroy(gameObject);
        }
    }
}
