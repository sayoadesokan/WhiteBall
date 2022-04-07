using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinscore : MonoBehaviour
{
    public static int coinamount;
    public GameObject coineffect;
    void Start()
    {
        Destroy(gameObject, 10f);
        Instantiate(coineffect, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            coinamount += 2;
            Instantiate(coineffect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
