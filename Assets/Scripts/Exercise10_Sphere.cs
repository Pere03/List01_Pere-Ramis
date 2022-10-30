using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise10_Sphere : MonoBehaviour
{
    private Exercise10 exercise10;

    private void Start()
    {
        exercise10 = FindObjectOfType<Exercise10>();
    }

    //When we click on the sphere, a point will be added to the counter and the sphere will be destroyed
    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            exercise10.AddPoint();

            Destroy(gameObject);
        }
    }
}
