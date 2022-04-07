using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody Fpush;
    public float addforce;
    private float screenwidth;

    private void Awake()
    {
        screenwidth = Screen.height / 2;
    }

    void Update()
    {
        FixedUpdate();
        TouchUpdate();
    }

    void FixedUpdate()
    {
        Fpush.AddForce(0f, 0f, 0f);

        if (Input.GetKeyDown("a"))
        {
            Fpush.AddForce(0f, 0f, -addforce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown("d"))
        {
            Fpush.AddForce(0f, 0f, addforce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }

    void TouchUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.position.x < screenwidth)
            {
                Fpush.AddForce(0f, 0f, -50 * Time.deltaTime, ForceMode.VelocityChange);
            }
            else if (touch.position.x > screenwidth)
            {
                Fpush.AddForce(0f, 0f, 50 * Time.deltaTime, ForceMode.VelocityChange);
            }
        }
    }
}