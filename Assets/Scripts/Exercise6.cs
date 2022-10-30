using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{
    public GameObject Cylinder;

    private Material matCylinder;

    private void Start()
    {
        matCylinder = Cylinder.GetComponent<Renderer>().material;
    }

    //Depending on which option you choose, the color of the cylinder will change
    public void ChangeColor(int index)
    {
        switch (index)
        {
            case 0:
                matCylinder.color = Color.white;
                break;

            case 1:
                matCylinder.color = Color.blue;
                break;

            case 2:
                matCylinder.color = Color.magenta;
                break;

            case 3:
                matCylinder.color = Color.black;
                break;

            case 4:
                matCylinder.color = Color.green;
                break;

            default:
                matCylinder.color = Color.white;
                break;
        }
    }
}
