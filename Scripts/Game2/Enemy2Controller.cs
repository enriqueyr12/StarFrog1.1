using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour
{
    private Transform Enemy;
    public float speed;
    public float maxBound, minBound, minHeight;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private bool noDisparar = false;
    private float hijosActuales = 0;
    private float nextFire;
    private bool derecha = true;
    private float contador = 0;
    private bool muerte = false;
    public float bajada;
    private bool cambiar = false;
    private double contadorDisparo = 0;
    private float cantidadDisparos = 0;
    public float level = 0; //Nivel 1 es normal, 2 es dificil y 0 niños 

    public bool acabarJuego2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FixedUpdate", 0.1f, 0.3f);
        Enemy = GetComponent<Transform>();
        hijosActuales = Enemy.childCount;
        acabarJuego2 = false;

    }

    // Update is called once per frame

    void FixedUpdate()
    {
        if (hijosActuales > Enemy.childCount)
        {
            hijosActuales = Enemy.childCount;
            muerte = true;
        }

        if ((Enemy.position.x > maxBound || Enemy.position.x < minBound) && !cambiar)
        {
            Enemy.position += Vector3.down * 1 / 50;
            contador += 1;
            if (contador == bajada)
            {
                if (derecha)
                {
                    derecha = false;
                }
                else
                {
                    derecha = true;
                }
                cambiar = true;
            }
        }
        else
        {
            if (derecha)
            {
                Enemy.position += Vector3.right * speed;
            }
            else
            {
                Enemy.position -= Vector3.right * speed;
            }
            contador = 0;
            cambiar = false;
        }


        if (level == 0)
        {
            noDisparar = true;
        }
        if (level == 1)
        {
            cantidadDisparos = 350;
            noDisparar = false;
        }
        if (level == 2)
        {
            cantidadDisparos = 100;
            noDisparar = false;
        }

        foreach (Transform nave_enemiga in Enemy)
        {
            if (!noDisparar)
            {
                contadorDisparo += 0.1;
                if (contadorDisparo > cantidadDisparos)
                {
                    Instantiate(shot, nave_enemiga.position, Enemy.rotation);
                    contadorDisparo = 0;
                }
            }

        }

        if (Enemy.childCount == 0)
        {
            acabarJuego2 = true;
        }





    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

    }

    public bool aumentarPuntuacion
    {
        get
        {
            if (muerte == true)
            {
                muerte = false;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
