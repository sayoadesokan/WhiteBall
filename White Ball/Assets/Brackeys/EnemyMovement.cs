using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{ 
    public Rigidbody rb;
    public float Pforce = 1000f;
   

    void FixedUpdate()
    {
        rb.AddForce(0f, 0f, Pforce * Time.deltaTime);
    }
}
