using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{

    private Transform Base;
    private Renderer colorBase;
    public int vidas;
    public int cambioColor = 0;

    // Start is called before the first frame update
    void Start()
    {
        Base = GetComponent<Transform>();
        colorBase = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {   

        if (vidas == 3)
        {
            colorBase.material.SetColor("_Color", Color.green);
        }
        if (vidas == 2)
        {
            colorBase.material.SetColor("_Color", Color.yellow);
        }
        if (vidas == 1)
        {
            colorBase.material.SetColor("_Color", Color.red);
        }
        if (vidas == 0) //Si las vidas de las 4 bases son 0 => cest fini
        {
            //Base.GetComponent<Renderer>().enabled = false;
            Base.position = new Vector3(-30.0f, -30.0f, 0.0f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (vidas > 0)
        {
            if (other.tag == "Bullet" || other.tag == "EnemyBullet")
            {
                cambioColor++;
                Destroy(other.gameObject);
                vidas--;

            }


            if (other.tag == "Enemy")
            {
                vidas = 0;
                Destroy(other.gameObject);
                
            }
        }

    }
}
