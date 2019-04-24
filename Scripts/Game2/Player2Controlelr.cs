using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Controlelr : MonoBehaviour
{
    private Transform player;
    public float speed;
    public float maxBound, minBound, maxHeight, minHeight;
    public GameObject shot, shot2, shot3;
    public Transform shotSpawn;
    public float fireRate;
    public float vidas = 3;
    private bool muerte = false;
    private float contadorMuerte = 0;

    private float nextFire;
    public float puntuacion = 0;
    public float level = 0;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
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

        player.position += Vector3.right * h * speed + Vector3.up * v * speed;

    }

    void Update()
    {


        if (level == 1)
        {
            if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

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
            //SceneManager.LoadScene("GameOver2");
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        /*if (other.tag == "EnemyBullet")
        {
            vidas--;
            player.position += Vector3.right * 50;
            muerte = true;

        }*/

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
