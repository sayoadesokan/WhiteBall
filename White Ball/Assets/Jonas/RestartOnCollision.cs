using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class RestartOnCollision : MonoBehaviour
{
    [SerializeField]
    string Ptag;

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.tag == Ptag) 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
