using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{

    public static bool GameOver = false;

    public GameObject gameOverMenuUI;

    public PlayerController lifes;

    public EnemyController enemies;

    public float vidas;

    public bool acabar;

    /*void Start()
    {
        vidas = lifes.vidas;
        acabar = enemies.acabarJuego;
    }*/


    void Update()
    {
        vidas = lifes.vidas;
        acabar = enemies.acabarJuego;


        if (vidas == 0 || acabar)
        {
            gameOverMenuUI.SetActive(true);
            GameOver = true;
            Time.timeScale = 0f;

        }
        else
        {
            gameOverMenuUI.SetActive(false);
            GameOver = false;
            //Time.timeScale = 1f;
        }

        //if (GameOver)
            //Time.timeScale = 0f;
         

    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        gameOverMenuUI.SetActive(false);
        GameOver = false;        
        SceneManager.LoadScene("MainMenu");

    }

    public void ResetGame()
    {
        
        gameOverMenuUI.SetActive(false);
        GameOver = false;        
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }

    public void ResetGame2()
    {
        gameOverMenuUI.SetActive(false);
        GameOver = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}