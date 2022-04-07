using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class therealpause : MonoBehaviour
{
    public static bool paused; 
    void Start()
    {
        paused = false; 
    }

    public void pause()
    {
        Time.timeScale = 0;
    }
}
