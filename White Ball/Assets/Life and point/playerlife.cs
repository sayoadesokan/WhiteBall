using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerlife : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject playereffect;
    public GameManager GameManager;
    public static int fivelife = 5;
    public Text five;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ebullet")
        {
            fivelife -= 1;
        }
    }
    public void Update()
    {
        five.text = fivelife.ToString();
        if (fivelife == 0)
        {
            player.SetActive(false);
            Instantiate(playereffect, transform.position, Quaternion.identity);
            enemy.SetActive(false);
            //Destroy(this.gameObject);
            endgame();
        }
    }

    public void endgame()
    {
        GameManager.EndGame();
    }
}
 