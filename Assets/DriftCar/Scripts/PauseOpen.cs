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
        Time.timeScale = 1; // ”бедитесь, что врем€ идет "в реальном времени" при запуске игры
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
            Time.timeScale = 0; // ќстанавливаем игру, установив врем€ на 0
        }
        else
        {
            Time.timeScale = 1; // ¬озобновл€ем игру, установив врем€ обратно на 1
        }
    }


   public void ResumeGame()
    {
        isPaused = false;
        pauseCanvas.enabled = false;
        Time.timeScale = 1;
    }
}
