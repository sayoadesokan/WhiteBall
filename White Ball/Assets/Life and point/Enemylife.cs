using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemylife : MonoBehaviour
{
    public float health = 2;
    public GameObject effect;
    public GameObject Coineffect;

    private Shake shake;

    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("shaker").GetComponent<Shake>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Shot")
        {
            health -= 1;
        }
    }

    public void Update()
    {
        if(health == 0)
        {
            shake.camshake();
            pointsandlife.thepoint += 1;
            Instantiate(effect, transform.position, Quaternion.identity);
            Instantiate(Coineffect, transform.position, Quaternion.identity);
            Destroy(this.gameObject); 
        }
    }
}
