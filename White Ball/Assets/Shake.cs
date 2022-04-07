using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public Animator camanim;

    public void camshake()
    {
        int rand = Random.Range(0, 3);
        if(rand == 0)
        {
            camanim.SetTrigger("shake00");
        }
        else if(rand == 1)
        {
            camanim.SetTrigger("shake01");
        }else if(rand == 2)
        {
            camanim.SetTrigger("shake02");
        }
    }
}
