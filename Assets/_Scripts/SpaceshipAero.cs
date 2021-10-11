using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipAero : MonoBehaviour {

    GameObject spaceship;
    Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 rawPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 targetPosition = new Vector3(rawPosition.x, rawPosition.y, 0f);
        rb2d.MovePosition(targetPosition);

       
	}
}
