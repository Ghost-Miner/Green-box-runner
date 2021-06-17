using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
	// 
	// THIS SCRIPT CURRENTLY CONTROLS THE WHOLE OPTIONS MENU
	//
	
    //Resolution[] resolutions; 			//List of all suported resolutions

    public Dropdown resolutionDropdown;		//REsoltuion dropdown, disabled

    /*void start()
    {
		//
		// Resoltuion settings and stuff
		//
		
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && 
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

	//Resoltuion settings
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }*/

	//Quality settings
    public void SetQuality(int qualityIndex)
    {
        Debug.Log("Quality:" + qualityIndex);
        QualitySettings.SetQualityLevel(qualityIndex);
    }

	//Fullscreen setttings
    public void SetFullScreen(bool isFullscreen)
    {
        Debug.Log("Fullscreen:" + isFullscreen);
        Screen.fullScreen = isFullscreen;
    }

	//Quit to menu
    public void BackToMenu()
    {
        Debug.Log("Returning to menu");
        SceneManager.LoadScene("MainMenu");
    }
}
