using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Timemanagement : MonoBehaviour
{
    public Text timertext;
    private float starttime;
    void Start()
    {
        starttime = Time.time;
    }

    void Update()
    {
        float t = Time.time - starttime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("F0");

        timertext.text = minutes + ":" + seconds;
    }
}
