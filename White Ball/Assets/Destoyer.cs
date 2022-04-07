using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoyer : MonoBehaviour
{
    public float lifetime;  

    private void start()
    {
        Destroy(gameObject, lifetime); 
    }

}
