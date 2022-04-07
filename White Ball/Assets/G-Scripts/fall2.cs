using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall2 : MonoBehaviour
{
    public Rigidbody rb;
    public float Fside;

    private float fside;

    void FixedUpdate()
    {
        fside = 0f;//If you do nothing then default speed to 0
        rb.AddForce(0f, 10f * Time.deltaTime, 0f);
        if (Input.GetKey("d"))
        {
            fside = Fside;
        }
        if (Input.GetKey("a"))
        {
            fside = -Fside; 
        }
        rb.AddForce(fside * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
    }
}

