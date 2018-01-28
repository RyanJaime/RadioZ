using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour {

	private float xDood;
	private float yDood;

	//values
	public int groupSize = 3;
	GameObject survivorSprites;

	// Use this for initialization
	void Start () {
		survivorSprites = GameObject.FindGameObjectWithTag ("Survivor Handler");
		if (groupSize == 3) {
			gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = survivorSprites.GetComponent<Ssprites> ().s3;
		} else if (groupSize == 7) {
			gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = survivorSprites.GetComponent<Ssprites> ().s7;

		} else {
			gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = survivorSprites.GetComponent<Ssprites> ().s10;

		}
		
	}
	
	// Update is called once per frame
	void Update () {
        {
			if (Input.GetKeyDown (KeyCode.W)) {
				xDood = 0.0f;
				yDood = 0.0f;
				yDood += 0.05f;
			}
			else if (Input.GetKeyDown (KeyCode.A)) {
				xDood = 0.0f;
				yDood = 0.0f;
				xDood -= 0.05f;
			}
			else if (Input.GetKeyDown (KeyCode.S)) {
				xDood = 0.0f;
				yDood = 0.0f;
				yDood -= 0.05f;
			}
			else if (Input.GetKeyDown (KeyCode.D)) {
				xDood = 0.0f;
				yDood = 0.0f;
				xDood += 0.05f;
			}
			else if (Input.GetKeyDown (KeyCode.Space)) {
				xDood = 0.0f;
				yDood = 0.0f;
			}

            /*var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;*/

			if (xDood >= 0.05) {
				xDood = 0.05f;
			}
			if (xDood <= -0.05) {
				xDood = -0.05f;
			}
			if (yDood >= 0.05) {
				yDood = 0.05f;
			}
			if (yDood <= -0.05) {
				yDood = -0.05f;
			}

            transform.Translate(xDood, yDood, 0);
        }
    }
}
