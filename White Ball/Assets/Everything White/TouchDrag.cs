using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDrag : MonoBehaviour
{
    private Vector3 touchposition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float movespeed; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchposition = Camera.main.ScreenToWorldPoint(touch.position);
            touchposition.z = 0;
            direction = (touchposition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * movespeed;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero; 
        }
    }
}
