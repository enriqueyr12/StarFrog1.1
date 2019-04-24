using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2Controller : MonoBehaviour {
    private Transform bullet2;

    public float speed;
    private int vidasBala = 3;
    // Use this for initialization
    void Start () {

        bullet2 = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        bullet2.position += Vector3.up * speed + Vector3.right * speed/2;

        if (vidasBala > 0)
        {
            if (bullet2.position.y >= 7.6 || bullet2.position.y <= -7.6)
            {
                speed = -speed;
                vidasBala--;
            }

            if (bullet2.position.x >= 11.6 || bullet2.position.x <= -11.6)
            {
                speed = -speed;
                vidasBala--;
            }
        }
        else
            Destroy(gameObject);

    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        else if(other.tag == "Base")
        {

            Destroy(gameObject);

        }


    }

}
