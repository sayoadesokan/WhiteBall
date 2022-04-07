using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetindicator : MonoBehaviour
{
    public Transform target;
    public float Hidedistance;

    void Update()
    {
        var dir = target.position - transform.position;

        if(dir.magnitude < Hidedistance)
        {
            setchildactive(false);
        }
        else
        {
            setchildactive(true);

            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    void setchildactive(bool value)
    {
        foreach(Transform child in transform)
        {
            child.gameObject.SetActive(value);
        }
    }
}
