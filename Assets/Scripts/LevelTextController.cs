using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class LevelTextController : MonoBehaviour
{

    public TMP_Text LevelText;
    public int LevelNumber;

    // Start is called before the first frame update
    void Start()
    {

        LevelNumber = SceneManager.GetActiveScene().buildIndex;

        LevelText.text = "Level " + LevelNumber;

        Invoke("BeginFade", 2f);

    }

    void BeginFade()
    {

        LevelText.alpha = 0;

    }

}
