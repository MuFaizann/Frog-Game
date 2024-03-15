using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class theHighest : MonoBehaviour
{
    public Text NameTextTwo;

    // Update is called once per frame
    void Update()
    {
        NameTextTwo.text = scoreTst.HighestPinCount.ToString();
    }
}
