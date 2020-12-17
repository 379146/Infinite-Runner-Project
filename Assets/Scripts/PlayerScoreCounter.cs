using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScoreCounter : MonoBehaviour
{

    public TMP_Text ScoreText;
    public int Score = 0;
    public int rand;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("LandingStartName");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore()
    {

        ++Score;
        ScoreText.text = "Score: " + Score;

        FindObjectOfType<AudioManager>().Play("CoinName");

        ScoreController.Score =Score;
    
    }

    public void SubScore()
    {

        --Score;
        ScoreText.text = "Score: " + Score;

        rand = Random.Range(1,7);

        FindObjectOfType<AudioManager>().Play("oof" + rand + "Name");

        ScoreController.Score = Score;

    }

}
