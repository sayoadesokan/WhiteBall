using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Boxmovement : MonoBehaviour
{
    public float movespeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    public Joystick joystick;

    public Text cointext;

    void Start()
    {
        cointext.GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;

        cointext.text = coinscore.coinamount.ToString();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
}
