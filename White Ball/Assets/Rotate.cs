﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Joystick joystick;
    void Update()
    {
        {
            Vector3 moveVector = (Vector3.up * joystick.Vertical - Vector3.left * joystick.Horizontal);
            if (joystick.Horizontal != 0 || joystick.Vertical != 0)
                transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
        }


    }
}
