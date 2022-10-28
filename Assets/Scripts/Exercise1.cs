using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise1 : MonoBehaviour
{
    public int RandomNumber;

    public TextMeshProUGUI Text;

    //Generate a random number and the number that comes out will be displayed in the text
    public void RandomNumberFunction()
    {
        RandomNumber = Random.Range(0, 1000);
        Text.text = RandomNumber.ToString();
    }
}
