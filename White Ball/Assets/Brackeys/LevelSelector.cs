using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor; 

public class LevelSelector : MonoBehaviour
{
    public Button[] levelButton;

    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1); 

        for (int i = 0; i < levelButton.Length; i++)
        {
            if (i + 1 > levelReached)
            levelButton[i].interactable = false; 
        }
    }

    public void ResetAll()
    {

        PlayerPrefs.DeleteAll();
        levelButton[1].interactable = false;
        levelButton[2].interactable = false;
        levelButton[3].interactable = false;
        levelButton[4].interactable = false;
        levelButton[5].interactable = false;
        levelButton[6].interactable = false;
        levelButton[7].interactable = false;
        levelButton[8].interactable = false;
        levelButton[9].interactable = false;
        Debug.Log("Reset All");
    }


    public void ChangeLevel1()
    {
        SceneManager.LoadScene(3); 
    }

    public void ChangeLevel2()
    {
        SceneManager.LoadScene(4);
    }

    public void ChangeLevel3()
    {
        SceneManager.LoadScene(5);
    }

    public void ChangeLevel4()
    {
        SceneManager.LoadScene(6);
    }

    public void ChangeLevel5()
    {
        SceneManager.LoadScene(7);
    }

    public void ChangeLevel6()
    {
        SceneManager.LoadScene(8);
    }

    public void ChangeLevel7()
    {
        SceneManager.LoadScene(9);
    }

    public void ChangeLevel8()
    {
        SceneManager.LoadScene(10);
    }

    public void ChangeLevel9()
    {
        SceneManager.LoadScene(11);
    }

    public void ChangeLevel10()
    {
        SceneManager.LoadScene(12);
    }

    public void ChangeLevel11()
    {
        SceneManager.LoadScene(13);
    }

    public void ChangeLevel12()
    {
        SceneManager.LoadScene(14);
    }

    public void ChangeLevel13()
    {
        SceneManager.LoadScene(15);
    }

    public void ChangeLevel14()
    {
        SceneManager.LoadScene(16);
    }

    public void ChangeLevel15()
    {
        SceneManager.LoadScene(17);
    }

    public void ChangeLevel16()
    {
        SceneManager.LoadScene(18);
    }

    public void ChangeLevel17()
    {
        SceneManager.LoadScene(19);
    }

    public void ChangeLevel18()
    {
        SceneManager.LoadScene(20);
    }

    public void ChangeLevel19()
    {
        SceneManager.LoadScene(21);
    }

    public void ChangeLevel20()
    {
        SceneManager.LoadScene(22);
    }
}
