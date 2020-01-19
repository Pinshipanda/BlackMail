using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsScripts : MonoBehaviour
{

    public AudioMixer audioMixer;

    Resolution[] resolutions;
    public Dropdown resolutionsDropdown;


    void Start()
    {
        resolutions = Screen.resolutions;

        int currentResolutionIndex = 0;

        List<string> options = new List<string>();
        for(int i = 0; i< resolutions.Length;  i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionsDropdown.AddOptions(options);
        resolutionsDropdown.value = currentResolutionIndex;
        resolutionsDropdown.RefreshShownValue();

    }
    
    public void VolumeSettings(float volumenValue)
    {
        audioMixer.SetFloat("volumen", volumenValue);

    }

    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void fullscreen(bool isFullScreeen)
    {
        Screen.fullScreen = isFullScreeen;

    }

    public void  SetResolution( int resolutionIdex)
    {
        Resolution resolution = resolutions[resolutionIdex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
