using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallAdjustMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Fside;

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
        if (!Input.GetKey("d") && !Input.GetKey("a"))
        {
            rb.velocity = Vector3.zero;
        }

    }
}
