using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        ScoringSystem.thescore += 1;
        Destroy(gameObject);
    }
}
