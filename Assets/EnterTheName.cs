using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterTheName : MonoBehaviour
{
    public InputField UserEnter; //PlayerName
    public static string myPlayerName;
    public Text ShowName;
    
    public void DisplayName()
    {
        myPlayerName = UserEnter.text; // assign input to string
        ShowName.text = myPlayerName; //assign string to textbox
    }
    
}
