using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour {
    BossController mejora;
    BossController puntuacion1;
    EnemyController puntuacion2;

    public HighScore actualizarPuntuacion;

    private Transform player;
    public float speed;
    public float maxBound, minBound, maxHeight, minHeight;
    public GameObject shot, shot2, shot3;
    public GameObject shots, shotss;
    public Transform shotSpawn;
    public float fireRate;
    public float vidas=3;
    private bool muerte = false;
    private float contadorMuerte = 0;
    private float probabilidad;
    private bool bloquear = false;
    private bool triple = false;
    private bool cambioColorBoss=false;
    private bool aux = false;
    public bool rank = false;
    

    private float nextFire;
    public float puntuacion;
    public float level=1;

	// Use this for initialization
	void Start () {
        mejora = GameObject.Find("Boss").GetComponent<BossController>();
        puntuacion1 = GameObject.Find("Boss").GetComponent<BossController>();
        puntuacion2 = GameObject.Find("Enemy").GetComponent<EnemyController>();
        player = GetComponent<Transform>();
        rank = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (player.position.x < minBound && h < 0)
            h = 0;
        else if (player.position.x > maxBound && h > 0)
            h = 0;

        if (player.position.y < minHeight && v < 0)
            v = 0;
        else if (player.position.y > maxHeight && v > 0)
            v = 0;

        player.position += Vector3.right * h  * speed + Vector3.up * v * speed;
        

    }

    void Update()
    {

        //------------ NO FUNCIONA BIEN, LO OMITO------------------
        /*if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            FindObjectOfType<AudioManager>().Play("MovimientoProtagonista");
        }else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            FindObjectOfType<AudioManager>().Stop("MovimientoProtagonista");
        }*/

        if (bloquear == false)
        {
            probabilidad = Random.Range(0, 10);
            bloquear = true;
            if (probabilidad > 5)
            {
                cambioColorBoss = true;
            }
            else
            {
                cambioColorBoss = false;
            }
        }
        


        if (mejora.Comprobacion == true)
        {
            aux = true;

            if (probabilidad > 5)
            {
                triple = true;
            }
            else
            {
                fireRate = 0.3f;
            } 
        }
        else
        {
            if (aux)
            {
                bloquear = false;
                aux = false;
            }
            triple = false;
            fireRate = 0.9f;
        }

        if (puntuacion1.aumentarPuntuacion == true)
        {
            puntuacion += 50;
        }

        if (puntuacion2.aumentarPuntuacion == true)
        {
            puntuacion += 10;
        }


        if (level == 1) {
            if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                if (triple)
                {
                Instantiate(shots, shotSpawn.position, Quaternion.Euler(new Vector3(0, 0, -45)));
                Instantiate(shotss, shotSpawn.position, Quaternion.Euler(new Vector3(0, 0, 45)));
                Instantiate(shot, shotSpawn.position, Quaternion.Euler(new Vector3(0, 0, 0)));
                }else
                {
                Instantiate(shot, shotSpawn.position, Quaternion.Euler(new Vector3(0,0,0)));
                }
                
                FindObjectOfType<AudioManager>().Play("DisparoProtagonista");

            }


        }

        if (muerte)
        {
            contadorMuerte++;
        }

        if (contadorMuerte > 70)
        {
            muerte = false;
            vidas--;
            player.position *= 0;
            player.position += Vector3.down * 6;
            contadorMuerte = 0;
            
        }

        if (vidas == 0)
        {
            //SceneManager.LoadScene("GameOver");
        }

    }

    public bool getData
    {
        get
        {
            return cambioColorBoss;
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        


        if (other.tag=="EnemyBullet")
        {
            
            player.position += Vector3.right * 50;
            muerte = true;
            
        }
        if (other.tag == "Enemy")
        {
            
            player.position += Vector3.right * 50;
            muerte = true;
        }

        if (other.tag == "Boss")
        {
            
            player.position += Vector3.right * 50;
            muerte = true;
        }
    }




}
