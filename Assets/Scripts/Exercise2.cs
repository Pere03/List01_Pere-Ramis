using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise2 : MonoBehaviour
{
    public int Number;

    public TextMeshProUGUI Text;

    void Update()
    {
        //When the space bar is pressed, it will indicate whether your number is even or odd
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (Number % 2 == 0)
            {
                Text.text = "Your number " + Number + " is even";
            }
            else
            {
                
                Text.text = "Your number " + Number + " is odd";
            }
        }
    }
}
