using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverui;
    public float delaytime; 
    public void EndGame()
    {
        StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(1f);

        gameoverui.SetActive(true);
    }
}
