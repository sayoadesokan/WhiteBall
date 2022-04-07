using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacledestroy : MonoBehaviour
{
    public int obstacletodeath = 6;
    public GameObject destroyeff;
    public GameObject hiteff;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Shot")
        {
            Instantiate(hiteff, transform.position, Quaternion.identity);
            obstacletodeath -= 1;
        }
        else if(collision.tag == "Ebullet")
        {
            Instantiate(hiteff, transform.position, Quaternion.identity);
            obstacletodeath -= 1;
        }
    }

    private void Update()
    {
        if(obstacletodeath == 0)
        {
            Instantiate(destroyeff, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
