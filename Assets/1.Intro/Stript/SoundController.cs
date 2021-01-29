using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public GameObject onButton;
    public GameObject offButton;
    public AudioSource sound;

    public void SoundOn()
    {
        sound.mute = true;
        offButton.SetActive(true);
        onButton.SetActive(false);
    }

    public void SoundOff()
    {
        sound.mute = false;
        offButton.SetActive(false);
        onButton.SetActive(true);
    }
}
