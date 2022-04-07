using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textfloatspeed : MonoBehaviour
{
    public float scrollspeed;
    public GameObject skipbutton;
    public GameObject Theboxtext;

    void Start()
    {
        StartCoroutine(skipbuttonui());
        StartCoroutine(theboxtextflow());
    }

    void Update()
    {
        Vector3 pos = transform.position;

        Vector3 localVectorUp = transform.TransformDirection(0, 1, 0);

        pos += localVectorUp * scrollspeed * Time.deltaTime;
        transform.position = pos; 
    }

    IEnumerator skipbuttonui()
    {
        yield return new WaitForSeconds(9f);

        skipbutton.SetActive(true);
    }

    IEnumerator theboxtextflow()
    {
        yield return new WaitForSeconds(4f);

        Theboxtext.SetActive(false);
    }
}
