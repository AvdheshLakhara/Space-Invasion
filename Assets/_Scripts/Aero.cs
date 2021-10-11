using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aero : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void update () {
        float dist = (transform.position.z - Camera.main.transform.position.z);

        float leftLimitation = Camera.main.ViewportToWorldPoint(new Vector3(0f, 0f, dist)).x;
        float rightLimitation = Camera.main.ViewportToWorldPoint(new Vector3(1f, 0f, dist)).x;

        float upLimitation = Camera.main.ViewportToWorldPoint(new Vector3(0f, 0f, dist)).y;
        float downLimitation = Camera.main.ViewportToWorldPoint(new Vector3(0f, 1f, dist)).y;

        float tempx = Mathf.Clamp(transform.position.x, leftLimitation, rightLimitation);
        float tempy = Mathf.Clamp(transform.position.y, upLimitation, downLimitation);

        transform.position = new Vector3(tempx, tempy, transform.position.z);
    }

}