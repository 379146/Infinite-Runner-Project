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

            Debug.Log("OBSTACLE");
            Destroy(gameObject);
            Destroy(body);

        }

    }

}
