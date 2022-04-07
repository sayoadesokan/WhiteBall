using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiateeffect : MonoBehaviour
{
    public GameObject collisioneffect;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "bullet")
        {
            Instantiate(collisioneffect, transform.position, Quaternion.identity);
        }
    }
}
