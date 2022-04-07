using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Selector_Script : MonoBehaviour
{
    public GameObject TheOne;
    public GameObject TheTwo;
    public GameObject TheThree;
    public GameObject TheFour;
    public GameObject TheFive;
    public GameObject TheSix;
    private Vector3 characterposition;
    private Vector3 offscreen;
    private int characterint = 1;
    private MeshRenderer TheOneRender, TheTwoRender, TheThreeRender, TheFourRender, TheFiveRender, TheSixRender;
    private readonly string selectedCharacter = "selectedCharacter"; 

    private void Awake()
    {
        characterposition = TheOne.transform.position;
        offscreen = TheTwo.transform.position;
        TheOneRender = TheOne.GetComponent<MeshRenderer>();
        TheTwoRender = TheOne.GetComponent<MeshRenderer>();
        TheThreeRender = TheOne.GetComponent<MeshRenderer>();
        TheFourRender = TheOne.GetComponent<MeshRenderer>();
        TheFiveRender = TheOne.GetComponent<MeshRenderer>();
        TheSixRender = TheOne.GetComponent<MeshRenderer>();
    }

    public void NextCharacter()
    {
        switch(characterint)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                TheOneRender.enabled = false;
                TheOne.transform.position = offscreen;
                TheTwo.transform.position = characterposition;
                TheTwoRender.enabled = true;
                characterint++; 
                break;
            case 2:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                TheTwoRender.enabled = false;
                TheTwo.transform.position = offscreen;
                TheThree.transform.position = characterposition;
                TheThreeRender.enabled = true;
                characterint++;
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter, 3);
                TheThreeRender.enabled = false;
                TheThree.transform.position = offscreen;
                TheFour.transform.position = characterposition;
                TheFourRender.enabled = true;
                characterint++;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCharacter, 4);
                TheFourRender.enabled = false;
                TheFour.transform.position = offscreen;
                TheFive.transform.position = characterposition;
                TheFiveRender.enabled = true;
                characterint++;
                break;
            case 5:
                PlayerPrefs.SetInt(selectedCharacter, 5);
                TheFiveRender.enabled = false;
                TheFive.transform.position = offscreen;
                TheSix.transform.position = characterposition;
                TheSixRender.enabled = true;
                characterint++;
                break;
            case 6:
                PlayerPrefs.SetInt(selectedCharacter, 6);
                TheSixRender.enabled = false;
                TheSix.transform.position = offscreen;
                TheOne.transform.position = characterposition;
                TheOneRender.enabled = true;
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
                PlayerPrefs.SetInt(selectedCharacter, 5);
                TheOneRender.enabled = false;
                TheOne.transform.position = offscreen;
                TheSix.transform.position = characterposition;
                TheSixRender.enabled = true; 
                ResetInt(); 
                break;
            case 2:
                PlayerPrefs.SetInt(selectedCharacter, 6);
                TheTwoRender.enabled = false;
                TheTwo.transform.position = offscreen;
                TheOne.transform.position = characterposition;
                TheOneRender.enabled = true;
                characterint--;
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                TheThreeRender.enabled = false;
                TheThree.transform.position = offscreen;
                TheTwo.transform.position = characterposition;
                TheTwoRender.enabled = true;
                characterint--;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                TheFourRender.enabled = false;
                TheFour.transform.position = offscreen;
                TheThree.transform.position = characterposition;
                TheThreeRender.enabled = true;
                characterint--;
                break;
            case 5:
                PlayerPrefs.SetInt(selectedCharacter, 3);
                TheFiveRender.enabled = false;
                TheFive.transform.position = offscreen;
                TheFour.transform.position = characterposition;
                TheFourRender.enabled = true;
                characterint--;
                break;
            case 6:
                PlayerPrefs.SetInt(selectedCharacter, 4);
                TheSixRender.enabled = false;
                TheSix.transform.position = offscreen;
                TheFive.transform.position = characterposition;
                TheFiveRender.enabled = true;
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

    public void changescene()
    {
        SceneManager.LoadScene(3); 
    }
}
