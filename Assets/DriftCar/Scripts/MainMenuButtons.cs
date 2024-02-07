using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    public Canvas settingCanvas;
    public Canvas selectlevelCanvas;

    private bool isSettingOpen = false;
    private bool isLevelSelectOpen = false;

    void Start()
    {
        settingCanvas.enabled = false;
        selectlevelCanvas.enabled = false;
    }

    public void ToggleCanvas(string canvasName)
    {
        if (canvasName == "Settings")
        {
            isSettingOpen = !isSettingOpen;
            settingCanvas.enabled = isSettingOpen;
            isLevelSelectOpen = false;
            selectlevelCanvas.enabled = false;
        }
        else if (canvasName == "SelectLevel")
        {
            isLevelSelectOpen = !isLevelSelectOpen;
            selectlevelCanvas.enabled = isLevelSelectOpen;
            isSettingOpen = false;
            settingCanvas.enabled = false;
        }
    }
}
