using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleportarget;
    public GameObject theplayer; 

    void OnTriggerEnter(Collider others)
    {
        theplayer.transform.position = teleportarget.transform.position;
        Destroy(gameObject, 2f); 
    }
}

