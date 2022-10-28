using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    public Vector3[] Positions;
    public GameObject Capsule;

    void Update()
    {
        // If the S key is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            //We store all the objects in the scene that have the "Capsule" tag in an array
            GameObject[] capsulesInGame = GameObject.FindGameObjectsWithTag("Capsule");

            //Every existing capsule will be erased
            foreach (GameObject capsule in capsulesInGame)
            {
                Destroy(capsule);
            }

            //Instantiate a capsule at each position of the array.
            foreach (Vector3 position in Positions)
            {
                Instantiate(Capsule, position, Capsule.transform.rotation);
            }
        }
    }
}
