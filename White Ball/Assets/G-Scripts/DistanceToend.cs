using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceToend : MonoBehaviour
{
    [SerializeField]
    private Transform endpoint;

    [SerializeField]
    private Text distanceText;

    private float distance;

    private void Update()
    {
        distance = (endpoint.transform.position - transform.position).magnitude;

        distanceText.text = "Green zone: " + distance.ToString("F0") + "m"; 
    }
}
