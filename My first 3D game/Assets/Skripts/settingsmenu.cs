using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class settingsmenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Dropdown ResolutionDropDown;
    public Resolution[] resolution;
    public void Start()
    {
        resolution = Screen.resolutions;
        ResolutionDropDown.ClearOptions();
        List<string> options = new List<string>();
        int currentresolution = 0;
        for (int i = 0; i < resolution.Length; i++)
        {
            string option = resolution[i].width + "x" + resolution[i].height;
            options.Add(option);
            if (resolution[i].width == Screen.currentResolution.width &&
                resolution[i].height == Screen.currentResolution.height)
            { currentresolution = i; }
        }
        ResolutionDropDown.AddOptions(options);
        ResolutionDropDown.value = currentresolution;
        ResolutionDropDown.RefreshShownValue();
    }
    public void setresolution(int resolutionindex)
    {
        Resolution res = resolution[resolutionindex];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }
    public void setvolume(float volume)
    {
        Debug.Log("activ vol");

        audioMixer.SetFloat("Vol", volume);
    }

    public void Grafix(int qualityindex)
    {
        QualitySettings.SetQualityLevel(qualityindex);
    }

    public void FullScreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
    }
}
