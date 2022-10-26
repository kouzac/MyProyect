using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] private Transform disparos;
    [SerializeField] private GameObject bala;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
    }
    private void Disparar()
    {
        Instantiate(bala, disparos.position, disparos.rotation);
    }
}
