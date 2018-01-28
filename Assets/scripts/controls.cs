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
	void FixedUpdate () {
        {
			if (Input.GetKeyDown (KeyCode.W)) {
				yDood += 0.01f;
			}
			if (Input.GetKeyDown (KeyCode.A)) {
				xDood -= 0.01f;
			}
			if (Input.GetKeyDown (KeyCode.S)) {
				yDood -= 0.01f;
			}
			if (Input.GetKeyDown (KeyCode.D)) {
				xDood += 0.01f;
			}

            /*var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;*/

			if (xDood >= 0.01) {
				xDood = 0.01f;
			}
			if (xDood <= -0.01) {
				xDood = -0.01f;
			}
			if (yDood >= 0.01) {
				yDood = 0.01f;
			}
			if (yDood <= -0.01) {
				yDood = -0.01f;
			}
			//print (xDood);

            transform.Translate(xDood, yDood, 0);
        }
    }
}
