using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Selector : MonoBehaviour
{
    [SerializeField]
    public GameObject The_One;
    public GameObject The_Two;
    public GameObject The_Three;
    public GameObject The_Four;
    public GameObject The_Five;
    public GameObject The_Six;
    private Vector3 characterposition;
    private Vector3 offscreen;
    private int characterint = 1;

    private void Awake()
    {
        characterposition = The_One.transform.position;
        offscreen = The_Two.transform.position;
    }

    public void NextCharacter()
    {
        switch (characterint)
        {
            case 1:
                The_One.transform.position = offscreen;
                The_Two.transform.position = characterposition;
                characterint++;
                break;
            case 2:
                The_Two.transform.position = offscreen;
                The_Three.transform.position = characterposition;
                characterint++;
                break;
            case 3:
                The_Three.transform.position = offscreen;
                The_Four.transform.position = characterposition;
                characterint++;
                break;
            case 4:
                The_Four.transform.position = offscreen;
                The_Five.transform.position = characterposition;
                characterint++;
                break;
            case 5:
                The_Five.transform.position = offscreen;
                The_Six.transform.position = characterposition;
                characterint++;
                break;
            case 6:
                The_Six.transform.position = offscreen;
                The_One.transform.position = characterposition;
                characterint++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;
        }
    }

    public void PreviousCharacter()
    {
        switch (characterint)
        {
            case 1:
                The_One.transform.position = offscreen;
                The_Six.transform.position = characterposition;
                ResetInt();
                break;
            case 2:
                The_Two.transform.position = offscreen;
                The_One.transform.position = characterposition;
                characterint--;
                break;
            case 3:
                The_Three.transform.position = offscreen;
                The_Two.transform.position = characterposition;
                characterint--;
                break;
            case 4:
                The_Four.transform.position = offscreen;
                The_Three.transform.position = characterposition;
                characterint--;
                break;
            case 5:
                The_Five.transform.position = offscreen;
                The_Four.transform.position = characterposition;
                characterint--;
                break;
            case 6:
                The_Six.transform.position = offscreen;
                The_Five.transform.position = characterposition;
                characterint--;
                break;
            default:
                ResetInt();
                break;
        }
    }

    private void ResetInt()
    {
        if (characterint >= 6)
        {
            characterint = 1;
        }
        else
        {
            characterint = 6;
        }
    }
}
