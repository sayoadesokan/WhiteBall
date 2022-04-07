using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchFall : MonoBehaviour
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

        if (rb.position.y < -10.3f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
