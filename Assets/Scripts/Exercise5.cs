using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    public Vector3[] Positions;
    public GameObject Capsule;

    void Update()
    {
        // If the S key is pressed all the objects in the scene that have the "Capsule" tag will be stored in an array and every capsule will be destroyed 
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject[] Capsules = GameObject.FindGameObjectsWithTag("Capsule");

            foreach (GameObject capsule in Capsules)
            {
                Destroy(capsule);
            }

            //This will instantiate a capsule in each position of the array that we have assigned in the inspector
            foreach (Vector3 position in Positions)
            {
                Instantiate(Capsule, position, Capsule.transform.rotation);
            }
        }
    }
}
