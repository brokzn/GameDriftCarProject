using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOpen : MonoBehaviour
{
    public Canvas pauseCanvas;
    private bool isPaused = false;

    void Start()
    {
        pauseCanvas.enabled = false;
        Time.timeScale = 1; // ���������, ��� ����� ���� "� �������� �������" ��� ������� ����
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    void TogglePauseMenu()
    {
        isPaused = !isPaused;
        pauseCanvas.enabled = isPaused;

        if (isPaused)
        {
            Time.timeScale = 0; // ������������� ����, ��������� ����� �� 0
        }
        else
        {
            Time.timeScale = 1; // ������������ ����, ��������� ����� ������� �� 1
        }
    }


   public void ResumeGame()
    {
        isPaused = false;
        pauseCanvas.enabled = false;
        Time.timeScale = 1;
    }
}
