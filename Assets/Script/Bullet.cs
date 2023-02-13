using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public Rigidbody rb;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(rb.velocity, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
