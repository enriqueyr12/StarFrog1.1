using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    private Transform Bullet;

    public float speed;

    private int vidasBala = 3;

	// Use this for initialization
	void Start () {

        Bullet = GetComponent<Transform>();

	}
	
    void FixedUpdate (){

        Bullet.position += Vector3.up * speed;

        
        if (vidasBala > 0)
        {
            if (Bullet.position.y >= 7.6 || Bullet.position.y <= -7.6)
            {
                speed = -speed;
                vidasBala--;
            }
        }
        else
            Destroy(gameObject);

    }

	void OnTriggerEnter2D (Collider2D other) {

        if(other.tag == "Enemy"){
            Destroy(other.gameObject);
            Destroy(gameObject);
            
        }
		
	}
}
