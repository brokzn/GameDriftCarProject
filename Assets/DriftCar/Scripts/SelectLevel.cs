using UnityEngine;
using UnityEngine.UI;

public class SelectLevel : MonoBehaviour
{
    public Canvas selectlevelCanvas;

    private bool isLevelSelected = false;

    void Start()
    {
        selectlevelCanvas.enabled = false;
    }

    public void ToggleLevelSelectMenu()
    {
        isLevelSelected = !isLevelSelected;
        selectlevelCanvas.enabled = isLevelSelected;
    }

}