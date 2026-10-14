using UnityEngine;

public class SettingsManager : MonoBehaviour
{

    public void ToggleFullscreen()
    { 
        Screen.fullScreen = !Screen.fullScreen;
        Debug.Log("Screen has changed");
    }

}
