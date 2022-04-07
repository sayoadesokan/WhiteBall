 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchFlow : MonoBehaviour
{
    public float MoveSpeed = 120f;
    public GameObject character;

    private Rigidbody characterbody;
    private float Screenwidth;

    private void Start()
    {
        Screenwidth = Screen.width;
        characterbody = character.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        int i = 0; 
        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > Screenwidth / 2)
            { //move right 
                Runcharacter(1.0f); 
            }
            if (Input.GetTouch(i).position.x < Screenwidth / 2)
            {//move left 
                Runcharacter(-1.0f);
            }
            ++i; 
        }
    }

    private void Runcharacter(float horizontalInput)
    {
        characterbody.AddForce(new Vector3(horizontalInput * MoveSpeed * Time.deltaTime, 0)); 
    }
}
