using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{

    public GameObject body;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            PlayerScoreCounter trigger = other.GetComponent<PlayerScoreCounter>();

            trigger.SubScore();

            Debug.Log("OBSTACLE");
            Destroy(gameObject);
            Destroy(body);

        }

    }

}
