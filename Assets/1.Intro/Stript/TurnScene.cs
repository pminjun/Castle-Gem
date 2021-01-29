using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TurnScene : MonoBehaviour
{
    public Image fade;

    void Update()
    {
        Debug.Log(fade.color.a);
        Debug.Log("white");
        if (fade.color.a == 1)
        {
            Debug.Log("black");
            SceneManager.LoadScene("Level1");
        }
    }
}
