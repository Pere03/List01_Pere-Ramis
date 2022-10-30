using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise8 : MonoBehaviour
{
    public TMP_InputField Username;
    public TextMeshProUGUI Welcome;

    public void ConfirmUsername()
    {
        //Here it checks with 2 conditions if the text field is empty or if there are blanks, and if neither of the 2 conditions is met, it will send the welcome greeting.
        if (string.IsNullOrEmpty(Username.text))
        {
            
        } 
        else
        {
            if (string.IsNullOrWhiteSpace(Username.text))
            {
               
            }
            else
            {
                Welcome.text = "Hello " + Username.text + ", welcome to this amazing adventure!";
            }
        }
    }
}
