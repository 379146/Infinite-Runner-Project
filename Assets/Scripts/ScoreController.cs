using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    //private static ScoreController _instance;

    //public int PlayerScore;

    //public static ScoreController Instance
    //{
    //    get
    //    {

    //        if (_instance == null)
    //            Debug.LogError("ScoreController NULL");

    //        return _instance;

    //    }


    //}

    //private void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //    _instance = this;
    //}

    //public int UpdateScore(int score)
    //{

    //    PlayerScore += score;

    //    return PlayerScore;

    //}

    private static int score;

    public static int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }




}
