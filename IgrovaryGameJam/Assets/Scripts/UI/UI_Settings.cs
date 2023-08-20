using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class UI_Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioMixer audioSFX;
    public AudioMixer audioMusic;

    Resolution[] resolutions;
    public Dropdown resDropdown;

    void Start()    {
        resolutions = Screen.resolutions;
        resDropdown.ClearOptions();
        List<string> option = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)    {
            string optio = resolutions[i].width + " x " + resolutions[i].height;
            option.Add(optio);
            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)   {
                    currentResolutionIndex = i;
                }
        }
        resDropdown.AddOptions(option);
        resDropdown.value = currentResolutionIndex;
        resDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex) {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetMasterVolume(float Volume)    {
        audioMixer.SetFloat("volume", Volume);
    }

    public void SetSFX(float Volume)    {
        audioSFX.SetFloat("sfx", Volume);
    }

    public void SetMusic(float Volume)    {
        audioMusic.SetFloat("music", Volume);
    }
    public void SetFullScreen(bool isFull)  {
        Screen.fullScreen = isFull;
    }
}
