using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
 
public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrememt;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 6;

    public GameObject effect;
    public Text healthDisplay; 
    

    private void Update()
    {
        healthDisplay.text = health.ToString(); 


        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);  

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrememt);
            
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrememt);
        }
    }
}
