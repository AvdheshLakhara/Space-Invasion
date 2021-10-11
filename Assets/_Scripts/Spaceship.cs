using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour {
    
    //GameObject spaceship;
    //private bool isCrashed = false;
    public Camera cam;
    private Rigidbody2D rb2d;
    private float maxWidth;
    //float speed = 5f;
    private float maxHeight;

    void Start()
    {   if(cam == null)
        {
            cam = Camera.main;
        }
        //Renderer rd = GetComponent<Renderer>();
        rb2d = GetComponent<Rigidbody2D>();
        //Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0f);

        //Vector3 lowerCorner = new Vector3(Screen.width, Screen.height, 0f);

        //Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);

        //Vector3 targetHeight = cam.ScreenToWorldPoint(lowerCorner);

        //float spaceshipWidth = rd.bounds.extents.x;
        //maxWidth = targetWidth.x - spaceshipWidth;

        //float spaceshipHeight = rd.bounds.extents.y;
        //maxHeight = targetHeight.y - spaceshipHeight;

    }
    	
	// Update is called once per frame
	void Update () {
        //Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        //Vector3 targetPosition = new Vector3(rawPosition.x, rawPosition.y, 0f);
        //float targetWidth = Mathf.Clamp(targetPosition.x, -maxWidth, maxWidth);
        //float targetHeight = Mathf.Clamp(targetPosition.y, -maxHeight, maxHeight);

        //targetPosition = new Vector3(targetHeight, targetPosition.y, targetPosition.z);
        //rb2d.MovePosition(targetPosition);

        //    transform.Translate(new Vector3(
        //        Input.GetAxis("Vertical") * speed,
        //        Input.GetAxis("Horizontal") * speed,
        //        0f) * Time.deltaTime);

       
            Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
            pos.x = Mathf.Clamp01(pos.x);
            pos.y = Mathf.Clamp01(pos.y);
            transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
    
}

