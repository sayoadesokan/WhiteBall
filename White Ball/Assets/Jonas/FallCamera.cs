using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCamera : MonoBehaviour
{

    [SerializeField]
    Transform Transtarget;  


    void Update()
    {
        transform.position = Transtarget.position; 
    }
}
