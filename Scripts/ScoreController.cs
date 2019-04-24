using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour
{

    public PlayerController score;
    public Text scoreText;
    

    void Update()
    {               
        scoreText.text = score.puntuacion.ToString();
    }


}
