using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise9 : MonoBehaviour
{
    public Toggle Switch;
    public Light PointLight;

    private void Start()
    {
        PointLightSwitch(Switch.isOn);
    }

    //This means that when we press the switch, it will turn the light on or off
    public void PointLightSwitch(bool isOn)
    {
        if (isOn)
        {
            PointLight.enabled = true;
        }
        else
        {
            PointLight.enabled = false;
        }
    }
}
