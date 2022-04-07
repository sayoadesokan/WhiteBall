using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Fside;
    public float restartvalue = -10.3f; 

    void FixedUpdate()
    {
        rb.AddForce(0f, 0f * Time.deltaTime, 0f);

        if (Input.GetKey("d"))
        {
            rb.AddForce(Fside * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-Fside * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
        }

        if (rb.position.y < restartvalue)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }    
}
