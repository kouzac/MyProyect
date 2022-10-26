using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class piedra : MonoBehaviour
{
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    transform.Translate(Vector2.left * speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
      //  if (other.CompareTag("Player")) {
        //    other.GetComponent<Player_controler>().health--;
          //  Instantiate(effect, transform.position, Quaternion.identity);
            //Destroy(gameObject);
        }   
   // }
}
