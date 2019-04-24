using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
  
    public void PlayGame () {

        //Dentro del primer parentesis tambien podríamos poner el nombre de la escena
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");

    }

    public void PlayGame2()
    {

        //Dentro del primer parentesis tambien podríamos poner el nombre de la escena
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game2");

    }

    public void QuitGame() {

        //Debug.Log("ERES UN PARGUELA");
        Application.Quit();

    }


}
