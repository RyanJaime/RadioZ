using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;

            transform.Translate(x, z,0);
        }
    }
}
