using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScoreDisplay : MonoBehaviour
{

    public int playerscore;
    public TMP_Text FinalScoreText;


    // Start is called before the first frame update
    void Start()
    {
        playerscore = ScoreController.Score;
        FinalScoreText.text = "Your Score For\nThis Level: " + playerscore;
        ScoreController.Score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
