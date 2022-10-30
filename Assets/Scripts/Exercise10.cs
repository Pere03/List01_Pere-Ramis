using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise10 : MonoBehaviour
{
    public TextMeshProUGUI Counter;

    public int Score;

    private void Start()
    {
        Score = 0;
    }

    //This function adds a dot to the counter, and puts it in the text
    public void AddPoint()
    {
        Score++;

        Counter.text = Score.ToString();
    }
}
