using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver2Controller : MonoBehaviour
{
    public static bool GameOver2 = false;

    public GameObject gameOverMenuUI2;

    public Player2Controlelr lifes2;

    public Enemy2Controller enemies2;

    public float vidas2;

    public bool acabar2;

    /*void Start()
    {
        vidas = lifes.vidas;
        acabar = enemies.acabarJuego;
    }*/


    void Update()
    {
        vidas2 = lifes2.vidas;
        acabar2 = enemies2.acabarJuego2;


        if (vidas2 == 0 || acabar2)
        {
            gameOverMenuUI2.SetActive(true);
            GameOver2 = true;
            Time.timeScale = 0f;

        }
        else
        {
            gameOverMenuUI2.SetActive(false);
            GameOver2 = false;
            //Time.timeScale = 1f;
        }

    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        gameOverMenuUI2.SetActive(false);
        GameOver2 = false;
        SceneManager.LoadScene("MainMenu");

    }

    public void ResetGame()
    {
        Time.timeScale = 1f;
        gameOverMenuUI2.SetActive(false);
        GameOver2 = false;
        SceneManager.LoadScene("Game");
    }

    public void ResetGame2()
    {
        gameOverMenuUI2.SetActive(false);
        GameOver2 = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
