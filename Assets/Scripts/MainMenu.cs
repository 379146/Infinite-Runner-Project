using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //public void PlayGame()
    //{

    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    //}

    public void Start()
    {

        if (!FindObjectOfType<AudioManager>().isplayingtheme)
        {
            FindObjectOfType<AudioManager>().Play("ThemeName");
        }

    }

    public void QuitGame()
    {

        Application.Quit();
    
    }

    public void StartLevel1()
    {

        SceneManager.LoadScene("Level_1");

    }

    public void StartLevel2()
    {

        SceneManager.LoadScene("Level_2");

    }

    public void StartLevel3()
    {

        SceneManager.LoadScene("Level_3");

    }

    public void Backtomenu()
    {

        SceneManager.LoadScene("Menu");

    }

}
