using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebScript : MonoBehaviour
{
    public void Facebook()
    {
        Application.OpenURL("www.facebook.com"); 
    }
    public void Twitter()
    {
        Application.OpenURL("www.twitter.com");
    }
    public void Instagram()
    {
        Application.OpenURL("www.instagram.com");
    }

}
