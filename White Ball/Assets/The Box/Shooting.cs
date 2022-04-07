using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletprefab;
    public Button button; 
    public float bulletforce = 20f;

    void Start()
    {
        button.onClick.AddListener(Shoot);
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletprefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletforce, ForceMode2D.Impulse);
    }
}
