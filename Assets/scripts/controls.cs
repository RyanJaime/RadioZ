using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour {

	private float xDood;
	private float yDood;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        {
			if (Input.GetKeyDown (KeyCode.W)) {
				xDood = 0.0f;
				yDood = 0.0f;
				yDood += 0.1f;
			}
			else if (Input.GetKeyDown (KeyCode.A)) {
				xDood = 0.0f;
				yDood = 0.0f;
				xDood -= 0.1f;
			}
			else if (Input.GetKeyDown (KeyCode.S)) {
				xDood = 0.0f;
				yDood = 0.0f;
				yDood -= 0.1f;
			}
			else if (Input.GetKeyDown (KeyCode.D)) {
				xDood = 0.0f;
				yDood = 0.0f;
				xDood += 0.1f;
			}
			else if (Input.GetKeyDown (KeyCode.Space)) {
				xDood = 0.0f;
				yDood = 0.0f;
			}

            /*var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;*/

			if (xDood >= 0.1) {
				xDood = 0.1f;
			}
			if (xDood <= -0.1) {
				xDood = -0.1f;
			}
			if (yDood >= 0.1) {
				yDood = 0.1f;
			}
			if (yDood <= -0.1) {
				yDood = -0.1f;
			}

            transform.Translate(xDood, yDood, 0);
        }
    }
}
