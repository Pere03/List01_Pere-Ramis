using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public float xRange = 3f;
    public float yRange = 3f;
    public float zRange = 3f;

    public float xPos;
    public float yPos;
    public float zPos;
   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Generate a random value for each position, within the range we have set for it
            xPos = Random.Range(-xRange, xRange);
            yPos = Random.Range(-yRange, yRange);
            zPos = Random.Range(-zRange, zRange);

            //Moves the cube to randomly generated positions
            transform.position = new Vector3(xPos, yPos, zPos);
        }
    }
}
