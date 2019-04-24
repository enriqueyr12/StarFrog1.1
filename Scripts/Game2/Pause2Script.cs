using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause2Script : MonoBehaviour
{

    public static bool Game2IsPaused = false;

    public GameObject pause2MenuUI;


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Game2IsPaused)
            {
                Resume2();
            }
            else
            {
                Pause2();
            }
        }

    }

    public void Resume2()
    {

        pause2MenuUI.SetActive(false);
        Time.timeScale = 1f;
        Game2IsPaused = false;

    }

    void Pause2()
    {

        pause2MenuUI.SetActive(true);
        Time.timeScale = 0f;
        Game2IsPaused = true;

    }

    public void LoadMenu2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        Game2IsPaused = false;

    }


    public void QuitGame2()
    {

        Application.Quit();

    }
}
