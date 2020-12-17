using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class LevelTextController : MonoBehaviour
{

    public TMP_Text LevelText;
    public int LevelNumber;
    public bool startfade = false;

    // Start is called before the first frame update
    void Start()
    {

        LevelNumber = SceneManager.GetActiveScene().buildIndex;

        LevelText.text = "Level " + LevelNumber;

        Invoke("BeginFade", 2f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        while (startfade && LevelText.alpha >= 0)
        {
            LevelText.alpha -= 0.01f;
            Debug.Log(LevelText.alpha);
        }

    }

    void BeginFade()
    {

        startfade = true;
    
    }

}
