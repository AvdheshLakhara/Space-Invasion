using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour {

    public Camera cam;

	// Use this for initialization
	void Start () {
		if(cam == null)
        {
            cam = Camera.main;
        }
	}
	
	// Update is called once per frame
	void Update () {
        float camHalfHeight = Camera.main.orthographicSize;
        float camHalfWidth = Camera.main.aspect * camHalfHeight;

        Bounds bounds = GetComponent<SpriteRenderer>().bounds;

        // Set a new vector to the top left of the scene 
        Vector3 topLeftPosition = new Vector3(-camHalfWidth, camHalfHeight, 0) + Camera.main.transform.position;

        // Offset it by the size of the object 
        topLeftPosition += new Vector3(bounds.size.x / 2, -bounds.size.y / 2, 0);

        transform.position = topLeftPosition;
    }
}