using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerScoreCounter : MonoBehaviour
{

    public TMP_Text ScoreText;
    public int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {

        ++Score;
        ScoreText.text = "Score: " + Score;
    
    }

    public void SubScore()
    {

        --Score;
        ScoreText.text = "Score: " + Score;

    }

}
