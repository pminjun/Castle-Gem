using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StonBtn : MonoBehaviour
{
    public Text stone1;
    public Text stone2;
    public Text stone3;
    public Text stone4;
    public Text stone5;

    public void stonCheck1()
    {
        stone1.text = (int.Parse(stone1.text) - 3).ToString();
    }
}
