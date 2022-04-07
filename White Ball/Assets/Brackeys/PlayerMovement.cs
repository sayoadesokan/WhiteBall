using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; 
    public  float Pforce = 1000f;
    public float Fsideways = 200f; 
    
    void FixedUpdate()
    {
        rb.AddForce(0f, 0f, Pforce * Time.deltaTime);
       
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(Fsideways * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange); 
        }
        else
            if (Input.GetKey("a"))
        {
            rb.AddForce(-Fsideways * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange); 
        }

    }
}
