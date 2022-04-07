using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Stats")]
    public float speed;
    public float stoppingDistance;
    public float retreatDistance; 
    public float startTimeBtwShots;
    private float timeBtwShots;
    private Rigidbody2D body;

    [Header("Reference")]
    public Transform shootposition;
    public GameObject shot;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            body.MovePosition(transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime));
        }
        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
            {
                transform.position = this.transform.position; 
            }
        else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
            {
            body.MovePosition(transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime));
            }


            if (timeBtwShots <=0)
                {
                GameObject toshoot = Instantiate(shot, shootposition.position, shootposition.rotation);
                timeBtwShots = startTimeBtwShots; 
                }
            else
            {
                timeBtwShots -= Time.deltaTime; 
            }
    }
}
