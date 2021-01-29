using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoneChecker : MonoBehaviour
{
    public int red;
    public int mint;
    public int yellow;
    public int godong;
    public int blue;

    public Text redStone;
    public Text mintStone;
    public Text yellowStone;
    public Text godongStone;
    public Text blueStone;


    void Start()
    {
        red = 0;
        mint = 0;
        yellow = 0;
        godong = 0;
        blue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        redStone.text = red.ToString();
        mintStone.text = mint.ToString();
        yellowStone.text = yellow.ToString();
        godongStone.text = godong.ToString();
        blueStone.text = blue.ToString();
    }
}
