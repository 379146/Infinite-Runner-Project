using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            PlayerScoreCounter trigger = other.GetComponent<PlayerScoreCounter>();

            trigger.AddScore();

            Debug.Log("JEWEL");
            Destroy(gameObject);

        }

    }
}
