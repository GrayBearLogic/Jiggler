using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    private bool isChecked = true;
    public void SoundOff()
    {
        isChecked = !isChecked;
        audioMixer.SetFloat("MasterVolume", isChecked?0:-80);
    }
}
