using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class SettingsManager : MonoBehaviour
{

    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private Toggle toggleFullScreen;
    Resolution[] allResolutions;

    bool isFull;

    int selectedOption;

    List<Resolution> selectedResolutions = new List<Resolution>();



    private void Start()
    {
        isFull = true;
        allResolutions = Screen.resolutions;
        PopulateResDropdown();
        
    }

    public void ChangeResolution()
    {
        selectedOption = dropdown.value;

        int scrWidth = allResolutions[selectedOption].width;
        int scrHeight = allResolutions[selectedOption].height;

        Screen.SetResolution(scrWidth, scrHeight, isFull);

        Debug.Log(scrWidth + "x" + scrHeight);
    }

    public void PopulateResDropdown()
    {
        List<string> resList = new List<string>();
        
        string newRes;

        foreach (Resolution res in allResolutions) 
        {
            newRes = res.width.ToString() + "x" + res.height.ToString();
            if(!resList.Contains(newRes))
            { 
                resList.Add(newRes);
                selectedResolutions.Add(res);
            }
        }

        dropdown.AddOptions(resList);
    }



    public void ToggleFullscreen()
    { 
        Screen.fullScreen = !Screen.fullScreen;
        Debug.Log("Screen has changed");
    }

}
