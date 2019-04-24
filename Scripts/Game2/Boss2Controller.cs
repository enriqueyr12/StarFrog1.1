using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2Controller : MonoBehaviour
{
    private Transform Boss;
    public GameObject shot;
    public Transform shotSpawn;
    private bool inicial = true;
    private float temporizador = 0;
    private float speed = 0.06f;
    private float speedAux = 1;
    private bool cambiarV = true;
    private bool detectar = false;
    private bool muerte = false;
    private bool muertePuntuacion = false;
    private bool Aux = false;
    private float temporizadorM = 0;
    private float temporizadorDisparo = 0;
    public float level = 0; //1 para el normal, 0 para el de niños 



    // Start is called before the first frame update
    void Start()
    {
        Boss = GetComponent<Transform>();
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        muertePuntuacion = false;
        if (inicial)
        {
            temporizadorDisparo++;
            temporizador++;
            if (temporizadorDisparo > 50)
            {
                if (level != 0)
                {
                    Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                    temporizadorDisparo = 0;
                }
            }
            if (temporizador > 565)
            {
                Boss.position += Vector3.right * speed * speedAux;
            }
            if (Boss.position.x > 20)
            {
                speedAux = 0;
                inicial = false;
                temporizador = 0;
            }
        }
        else
        {
            temporizador++;
            temporizadorDisparo++;
            if (temporizadorDisparo > 50)
            {
                if (level != 0)
                {
                    Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                    temporizadorDisparo = 0;
                }
            }
            if (muerte)
            {
                temporizadorM++;
            }
            if (temporizadorM > 200)
            {
                muerte = false;
                temporizadorM = 0;
            }
            if (temporizador > 565)
            {
                speedAux = 1;
                if (cambiarV)
                {
                    speed = -speed;
                    cambiarV = false;
                    if (Aux)
                    {
                        Boss.position -= Vector3.up * -100;
                        Aux = false;
                    }
                }
                Boss.position += Vector3.right * speed * speedAux;
                if (Boss.position.x > -3 || Boss.position.x < 3)
                {
                    detectar = true;
                }
                if (detectar)
                {
                    if (Boss.position.x > 20 || Boss.position.x < -20)
                    {
                        detectar = false;
                        cambiarV = true;
                        speedAux = 0;
                        temporizador = 0;
                    }
                }

            }
        }
    }

    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            muerte = true;
            muertePuntuacion = true;
            Aux = true;
            Boss.position += Vector3.up * -100;
        }
    }

    public bool Comprobacion
    {
        get
        {
            return muerte;
        }
    }

    public bool aumentarPuntuacion
    {
        get
        {
            if (muerte && muertePuntuacion)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
