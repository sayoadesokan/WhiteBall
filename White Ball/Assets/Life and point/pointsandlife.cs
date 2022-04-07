using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class pointsandlife : MonoBehaviour
{
    public Text pointtext;
    public static int thepoint;

    void Update()
    {
        pointtext.text = thepoint.ToString();

        if(thepoint >= 50)
        {
            coinscore.coinamount += 5;
        }
        if (thepoint >= 100)
        {
            coinscore.coinamount += 15;
        }
        if (thepoint >= 150)
        {
            coinscore.coinamount += 30;
        }
    }
}
