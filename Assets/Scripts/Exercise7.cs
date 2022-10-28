using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    public GameObject Sphere;

    private Material matSphere;

    private void Start()
    {
        matSphere = Sphere.GetComponent<Renderer>().material;
    }

    // Changes the transparency of the sphere according to the slider value.
    public void ChangeAlphaValue(float value)
    {
        matSphere.color = new Vector4(matSphere.color.r, matSphere.color.b, matSphere.color.g, value);
    }
}
