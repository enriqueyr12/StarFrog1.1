using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
   // highScore1.text = puntuacion.ToString();

    public PlayerController partidaActual;
    public float puntuacion;

    public Text highScore1;
    public Text highScore2;
    public Text highScore3;
    public Text highScore4;
    public Text highScore5;
    public Text highScore6;
    public Text highScore7;
    public Text highScore8;
    public Text highScore9;
    public Text highScore10;
    public Text n1;
    public Text n2;
    public Text n3;
    public Text n4;
    public Text n5;
    public Text n6;
    public Text n7;
    public Text n8;
    public Text n9;
    public Text n10;
    private bool bloquear=true;
    private bool permisoNombre = false;
    private string nombre="";
    private string porDefecto = "---";
    private string posicion;



    void Start()
    {

        highScore1.text = PlayerPrefs.GetFloat("HighScore1").ToString();
        highScore2.text = PlayerPrefs.GetFloat("HighScore2").ToString();
        highScore3.text = PlayerPrefs.GetFloat("HighScore3").ToString();
        highScore4.text = PlayerPrefs.GetFloat("HighScore4").ToString();
        highScore5.text = PlayerPrefs.GetFloat("HighScore5").ToString();
        highScore6.text = PlayerPrefs.GetFloat("HighScore6").ToString();
        highScore7.text = PlayerPrefs.GetFloat("HighScore7").ToString();
        highScore8.text = PlayerPrefs.GetFloat("HighScore8").ToString();
        highScore9.text = PlayerPrefs.GetFloat("HighScore9").ToString();
        highScore10.text = PlayerPrefs.GetFloat("HighScore10").ToString();
        n1.text = PlayerPrefs.GetString("n1").ToString();
        n2.text = PlayerPrefs.GetString("n2").ToString();
        n3.text = PlayerPrefs.GetString("n3").ToString();
        n4.text = PlayerPrefs.GetString("n4").ToString();
        n5.text = PlayerPrefs.GetString("n5").ToString();
        n6.text = PlayerPrefs.GetString("n6").ToString();
        n7.text = PlayerPrefs.GetString("n7").ToString();
        n8.text = PlayerPrefs.GetString("n8").ToString();
        n9.text = PlayerPrefs.GetString("n9").ToString();
        n10.text = PlayerPrefs.GetString("n10").ToString();
    }



    // Update is called once per frame

    void OnGUI()
    {
        if (GUI.Button(new Rect(100, 200, 200, 60), "Reiniciar Ranking"))
        {
            PlayerPrefs.SetFloat("HighScore10", 0);
            PlayerPrefs.SetFloat("HighScore9", 0);
            PlayerPrefs.SetFloat("HighScore8", 0);
            PlayerPrefs.SetFloat("HighScore7", 0);
            PlayerPrefs.SetFloat("HighScore6", 0);
            PlayerPrefs.SetFloat("HighScore5", 0);
            PlayerPrefs.SetFloat("HighScore4", 0);
            PlayerPrefs.SetFloat("HighScore3", 0);
            PlayerPrefs.SetFloat("HighScore2", 0);
            PlayerPrefs.SetFloat("HighScore1", 0);
            PlayerPrefs.SetString("n1", porDefecto);
            PlayerPrefs.SetString("n2", porDefecto);
            PlayerPrefs.SetString("n3", porDefecto);
            PlayerPrefs.SetString("n4", porDefecto);
            PlayerPrefs.SetString("n5", porDefecto);
            PlayerPrefs.SetString("n6", porDefecto);
            PlayerPrefs.SetString("n7", porDefecto);
            PlayerPrefs.SetString("n8", porDefecto);
            PlayerPrefs.SetString("n9", porDefecto);
            PlayerPrefs.SetString("n10", porDefecto);
            PlayerPrefs.SetString("nombre", porDefecto);
        }

        if (permisoNombre)
        {
            nombre = GUI.TextField(new Rect(219, 100, 100, 20), nombre, 3);
            if (GUI.Button(new Rect(220, 130, 120, 30), "Introducir nombre"))
            {
                PlayerPrefs.SetString("nombre", nombre);
            }
        }
    }


    void Update()
    {

        Start();

        puntuacion = partidaActual.puntuacion;
        PlayerPrefs.SetString(posicion, PlayerPrefs.GetString("nombre", porDefecto));

        if (partidaActual.vidas==0 && (puntuacion > PlayerPrefs.GetFloat("HighScore10", 0)))
        {
            permisoNombre = true;
        }

        if (partidaActual.vidas == 0)
        {
            if (partidaActual.rank == true)
            {
                bloquear = false;
                partidaActual.rank = false;
                PlayerPrefs.SetString("nombre", nombre);
            }
        }

        if (bloquear == false)
        {
            if ((PlayerPrefs.GetFloat("HighScore1", 0)) < puntuacion)
            {
                PlayerPrefs.SetFloat("HighScore10", PlayerPrefs.GetFloat("HighScore9", 0));
                PlayerPrefs.SetFloat("HighScore9", PlayerPrefs.GetFloat("HighScore8", 0));
                PlayerPrefs.SetFloat("HighScore8", PlayerPrefs.GetFloat("HighScore7", 0));
                PlayerPrefs.SetFloat("HighScore7", PlayerPrefs.GetFloat("HighScore6", 0));
                PlayerPrefs.SetFloat("HighScore6", PlayerPrefs.GetFloat("HighScore5", 0));
                PlayerPrefs.SetFloat("HighScore5", PlayerPrefs.GetFloat("HighScore4", 0));
                PlayerPrefs.SetFloat("HighScore4", PlayerPrefs.GetFloat("HighScore3", 0));
                PlayerPrefs.SetFloat("HighScore3", PlayerPrefs.GetFloat("HighScore2", 0));
                PlayerPrefs.SetFloat("HighScore2", PlayerPrefs.GetFloat("HighScore1", 0));
                PlayerPrefs.SetString("n10", PlayerPrefs.GetString("n9", "---"));
                PlayerPrefs.SetString("n9", PlayerPrefs.GetString("n8", "---"));
                PlayerPrefs.SetString("n8", PlayerPrefs.GetString("n7", "---"));
                PlayerPrefs.SetString("n7", PlayerPrefs.GetString("n6", "---"));
                PlayerPrefs.SetString("n6", PlayerPrefs.GetString("n5", "---"));
                PlayerPrefs.SetString("n5", PlayerPrefs.GetString("n4", "---"));
                PlayerPrefs.SetString("n4", PlayerPrefs.GetString("n3", "---"));
                PlayerPrefs.SetString("n3", PlayerPrefs.GetString("n2", "---"));
                PlayerPrefs.SetString("n2", PlayerPrefs.GetString("n1", "---"));
                PlayerPrefs.SetFloat("HighScore1", puntuacion);
                posicion = "n1";
            }
            else
            {
                if ((PlayerPrefs.GetFloat("HighScore2", 0)) < puntuacion)
                {
                    PlayerPrefs.SetFloat("HighScore10", PlayerPrefs.GetFloat("HighScore9", 0));
                    PlayerPrefs.SetFloat("HighScore9", PlayerPrefs.GetFloat("HighScore8", 0));
                    PlayerPrefs.SetFloat("HighScore8", PlayerPrefs.GetFloat("HighScore7", 0));
                    PlayerPrefs.SetFloat("HighScore7", PlayerPrefs.GetFloat("HighScore6", 0));
                    PlayerPrefs.SetFloat("HighScore6", PlayerPrefs.GetFloat("HighScore5", 0));
                    PlayerPrefs.SetFloat("HighScore5", PlayerPrefs.GetFloat("HighScore4", 0));
                    PlayerPrefs.SetFloat("HighScore4", PlayerPrefs.GetFloat("HighScore3", 0));
                    PlayerPrefs.SetFloat("HighScore3", PlayerPrefs.GetFloat("HighScore2", 0));
                    PlayerPrefs.SetString("n10", PlayerPrefs.GetString("n9", "---"));
                    PlayerPrefs.SetString("n9", PlayerPrefs.GetString("n8", "---"));
                    PlayerPrefs.SetString("n8", PlayerPrefs.GetString("n7", "---"));
                    PlayerPrefs.SetString("n7", PlayerPrefs.GetString("n6", "---"));
                    PlayerPrefs.SetString("n6", PlayerPrefs.GetString("n5", "---"));
                    PlayerPrefs.SetString("n5", PlayerPrefs.GetString("n4", "---"));
                    PlayerPrefs.SetString("n4", PlayerPrefs.GetString("n3", "---"));
                    PlayerPrefs.SetString("n3", PlayerPrefs.GetString("n2", "---"));
                    PlayerPrefs.SetFloat("HighScore2", puntuacion);
                    posicion = "n2";
                }
                else
                {
                    if ((PlayerPrefs.GetFloat("HighScore3", 0)) < puntuacion)
                    {
                        PlayerPrefs.SetFloat("HighScore10", PlayerPrefs.GetFloat("HighScore9", 0));
                        PlayerPrefs.SetFloat("HighScore9", PlayerPrefs.GetFloat("HighScore8", 0));
                        PlayerPrefs.SetFloat("HighScore8", PlayerPrefs.GetFloat("HighScore7", 0));
                        PlayerPrefs.SetFloat("HighScore7", PlayerPrefs.GetFloat("HighScore6", 0));
                        PlayerPrefs.SetFloat("HighScore6", PlayerPrefs.GetFloat("HighScore5", 0));
                        PlayerPrefs.SetFloat("HighScore5", PlayerPrefs.GetFloat("HighScore4", 0));
                        PlayerPrefs.SetFloat("HighScore4", PlayerPrefs.GetFloat("HighScore3", 0));
                        PlayerPrefs.SetString("n10", PlayerPrefs.GetString("n9", "---"));
                        PlayerPrefs.SetString("n9", PlayerPrefs.GetString("n8", "---"));
                        PlayerPrefs.SetString("n8", PlayerPrefs.GetString("n7", "---"));
                        PlayerPrefs.SetString("n7", PlayerPrefs.GetString("n6", "---"));
                        PlayerPrefs.SetString("n6", PlayerPrefs.GetString("n5", "---"));
                        PlayerPrefs.SetString("n5", PlayerPrefs.GetString("n4", "---"));
                        PlayerPrefs.SetString("n4", PlayerPrefs.GetString("n3", "---"));
                        PlayerPrefs.SetFloat("HighScore3", puntuacion);
                        posicion = "n3";
                    }
                    else
                    {
                        if ((PlayerPrefs.GetFloat("HighScore4", 0)) < puntuacion)
                        {
                            PlayerPrefs.SetFloat("HighScore10", PlayerPrefs.GetFloat("HighScore9", 0));
                            PlayerPrefs.SetFloat("HighScore9", PlayerPrefs.GetFloat("HighScore8", 0));
                            PlayerPrefs.SetFloat("HighScore8", PlayerPrefs.GetFloat("HighScore7", 0));
                            PlayerPrefs.SetFloat("HighScore7", PlayerPrefs.GetFloat("HighScore6", 0));
                            PlayerPrefs.SetFloat("HighScore6", PlayerPrefs.GetFloat("HighScore5", 0));
                            PlayerPrefs.SetFloat("HighScore5", PlayerPrefs.GetFloat("HighScore4", 0));
                            PlayerPrefs.SetString("n10", PlayerPrefs.GetString("n9", "---"));
                            PlayerPrefs.SetString("n9", PlayerPrefs.GetString("n8", "---"));
                            PlayerPrefs.SetString("n8", PlayerPrefs.GetString("n7", "---"));
                            PlayerPrefs.SetString("n7", PlayerPrefs.GetString("n6", "---"));
                            PlayerPrefs.SetString("n6", PlayerPrefs.GetString("n5", "---"));
                            PlayerPrefs.SetString("n5", PlayerPrefs.GetString("n4", "---"));
                            PlayerPrefs.SetFloat("HighScore4", puntuacion);
                            posicion = "n4";
                        }
                        else
                        {
                            if ((PlayerPrefs.GetFloat("HighScore5", 0)) < puntuacion)
                            {
                                PlayerPrefs.SetFloat("HighScore10", PlayerPrefs.GetFloat("HighScore9", 0));
                                PlayerPrefs.SetFloat("HighScore9", PlayerPrefs.GetFloat("HighScore8", 0));
                                PlayerPrefs.SetFloat("HighScore8", PlayerPrefs.GetFloat("HighScore7", 0));
                                PlayerPrefs.SetFloat("HighScore7", PlayerPrefs.GetFloat("HighScore6", 0));
                                PlayerPrefs.SetFloat("HighScore6", PlayerPrefs.GetFloat("HighScore5", 0));
                                PlayerPrefs.SetString("n10", PlayerPrefs.GetString("n9", "---"));
                                PlayerPrefs.SetString("n9", PlayerPrefs.GetString("n8", "---"));
                                PlayerPrefs.SetString("n8", PlayerPrefs.GetString("n7", "---"));
                                PlayerPrefs.SetString("n7", PlayerPrefs.GetString("n6", "---"));
                                PlayerPrefs.SetString("n6", PlayerPrefs.GetString("n5", "---"));
                                PlayerPrefs.SetFloat("HighScore5", puntuacion);
                                posicion = "n5";
                            }
                            else
                            {
                                if ((PlayerPrefs.GetFloat("HighScore6", 0)) < puntuacion)
                                {
                                    PlayerPrefs.SetFloat("HighScore10", PlayerPrefs.GetFloat("HighScore9", 0));
                                    PlayerPrefs.SetFloat("HighScore9", PlayerPrefs.GetFloat("HighScore8", 0));
                                    PlayerPrefs.SetFloat("HighScore8", PlayerPrefs.GetFloat("HighScore7", 0));
                                    PlayerPrefs.SetFloat("HighScore7", PlayerPrefs.GetFloat("HighScore6", 0));
                                    PlayerPrefs.SetString("n10", PlayerPrefs.GetString("n9", "---"));
                                    PlayerPrefs.SetString("n9", PlayerPrefs.GetString("n8", "---"));
                                    PlayerPrefs.SetString("n8", PlayerPrefs.GetString("n7", "---"));
                                    PlayerPrefs.SetString("n7", PlayerPrefs.GetString("n6", "---"));
                                    PlayerPrefs.SetFloat("HighScore6", puntuacion);
                                    posicion = "n6";
                                }
                                else
                                {
                                    if ((PlayerPrefs.GetFloat("HighScore7", 0)) < puntuacion)
                                    {
                                        PlayerPrefs.SetFloat("HighScore10", PlayerPrefs.GetFloat("HighScore9", 0));
                                        PlayerPrefs.SetFloat("HighScore9", PlayerPrefs.GetFloat("HighScore8", 0));
                                        PlayerPrefs.SetFloat("HighScore8", PlayerPrefs.GetFloat("HighScore7", 0));
                                        PlayerPrefs.SetString("n10", PlayerPrefs.GetString("n9", "---"));
                                        PlayerPrefs.SetString("n9", PlayerPrefs.GetString("n8", "---"));
                                        PlayerPrefs.SetString("n8", PlayerPrefs.GetString("n7", "---"));
                                        PlayerPrefs.SetFloat("HighScore7", puntuacion);
                                        posicion = "n7";
                                    }
                                    else
                                    {
                                        if ((PlayerPrefs.GetFloat("HighScore8", 0)) < puntuacion)
                                        {
                                            PlayerPrefs.SetFloat("HighScore10", PlayerPrefs.GetFloat("HighScore9", 0));
                                            PlayerPrefs.SetFloat("HighScore9", PlayerPrefs.GetFloat("HighScore8", 0));
                                            PlayerPrefs.SetString("n10", PlayerPrefs.GetString("n9", "---"));
                                            PlayerPrefs.SetString("n9", PlayerPrefs.GetString("n8", "---"));    
                                            PlayerPrefs.SetFloat("HighScore8", puntuacion);
                                            posicion = "n8";
                                        }
                                        else
                                        {
                                            if ((PlayerPrefs.GetFloat("HighScore9", 0)) < puntuacion)
                                            {
                                                PlayerPrefs.SetFloat("HighScore10", PlayerPrefs.GetFloat("HighScore9", 0));
                                                PlayerPrefs.SetString("n10", PlayerPrefs.GetString("n9", "---"));
                                                PlayerPrefs.SetFloat("HighScore9", puntuacion);
                                                posicion = "n9";
                                            }
                                            else
                                            {
                                                if ((PlayerPrefs.GetFloat("HighScore10", 0)) < puntuacion)
                                                {
                                                    PlayerPrefs.SetFloat("HighScore10", puntuacion);
                                                    posicion = "n10";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            bloquear = true;
        }
        



    }

    
}
