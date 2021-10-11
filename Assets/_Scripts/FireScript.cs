using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour {

    public GameObject bulletPrefab;
    Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {


        //rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            FireBullet();
        }
	}

    public void FireBullet()
    {
        GameObject Clone;

        Clone = (Instantiate(bulletPrefab, transform.position + 1.0f * transform.forward, 
                transform.rotation)) as GameObject;

        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
    }
}
