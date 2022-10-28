using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public GameObject Sphere;

    //Using the screen slider, we will change the scale of the object
    public void ScaleController(float scale)
    {
        Sphere.transform.localScale = new Vector3(scale, scale, scale);
    }
}
