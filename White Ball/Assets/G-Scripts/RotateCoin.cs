using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public int RotateSpeed;

    void Update()
    {
        transform.Rotate(RotateSpeed, 0, 0, Space.World);
    }
}
