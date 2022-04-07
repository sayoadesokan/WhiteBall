using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranstionFlowBox : MonoBehaviour
{
    public GameObject transitionflow;
    private void Awake()
    {
        transitionflow.SetActive(true);
        StartCoroutine(transdes());
    }

    IEnumerator transdes()
    {
        yield return new WaitForSeconds(1f);

        Destroy(transitionflow);
    }
}
