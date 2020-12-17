using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{


    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            EndLevel();
            FindObjectOfType<AudioManager>().Play("CompleteName");
        }

    }


    public void EndLevel()
    {

        SceneManager.LoadScene("End_Screen");

    }

}
