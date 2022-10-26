using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1 * Time.deltaTime, 0);
        if (transform.position.x < -5.17)
        {
            transform.position = new Vector3(3.3f, transform.position.y);
        }
    }
}
