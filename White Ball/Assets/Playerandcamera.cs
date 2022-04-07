using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerandcamera : MonoBehaviour
{
    public Transform Playersprite;
    //public float cameradistance = 30f; 
    //void Awake()
    //{
        //GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameradistance);
    //}

    void Update()
    {
        transform.position =  new Vector3(Playersprite.transform.position.x, Playersprite.transform.position.y, transform.position.z);
    }
}
