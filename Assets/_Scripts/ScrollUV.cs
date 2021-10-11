using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollUV : MonoBehaviour {
		
	
	
	// Update is called once per frame
	void Update () {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.materials[0];

        Vector2 offset = mat.mainTextureOffset;
        offset.x += Time.deltaTime / 10f;
        mat.mainTextureOffset = offset;		
	}
}
