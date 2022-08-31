using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    private bool isGamePaused = false;

    public bool isGameOver = false;

    public GameObject pauseMenu;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !isGameOver)
        {
            if (!isGamePaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    private void Pause()
    {
        //Set Time Scale
        Time.timeScale = 0;

        //Pause Menu
        pauseMenu.SetActive(true);

        //Set Boolean
        isGamePaused = true;
    }

    private void Resume()
    {
        //Set Time Scale
        Time.timeScale = 1;

        //Pause Menu
        pauseMenu.SetActive(false);

        //Set Boolean
        isGamePaused = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
