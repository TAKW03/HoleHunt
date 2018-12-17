using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour {

    public AudioMixer audioMixer;

    public TMP_Dropdown resolutionTMP_Dropdown;

    Resolution[] resolutions;

    private void Start()
    {
        resolutions = Screen.resolutions;

        resolutionTMP_Dropdown.ClearOptions();

        List<string> options = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

        }

        resolutionTMP_Dropdown.AddOptions(options);

    }


    public void SetVolume (float MainVolume)
    {
        audioMixer.SetFloat("MainVolume", MainVolume);
    }


    public void SetMusicVolume(float MusicVolume)
    {
        audioMixer.SetFloat("MusicVolume", MusicVolume);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

}
