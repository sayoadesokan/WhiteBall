using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamp : MonoBehaviour
{

    void Update()
    {
        transform.position = new Vector3 (Mathf.Clamp(transform.position.x, -1, 1), Mathf.Clamp(transform.position.y, -0, 1), transform.position.z); 
    }
}
