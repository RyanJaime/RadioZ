using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class controls : MonoBehaviour {

	private float xDood;
	private float yDood;

	//values
	public int groupSize = 3;
	GameObject survivorSprites;
    public GameObject SpeechBubble;
    public GameObject SpeechText;

	// Use this for initialization
	void Start () {
        SpeechBubble = GameObject.FindGameObjectWithTag("bubbletag");
        SpeechText = GameObject.FindGameObjectWithTag("text");
        SpeechText.GetComponent<TextMeshProUGUI>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
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
                //GameObject.FindGameObjectWithTag ("bubbletag");
                SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
                SpeechText.GetComponent<TextMeshProUGUI>().enabled = true;
                SpeechText.GetComponent<TextMeshProUGUI>().SetText("North");
                xDood = 0.0f;
				yDood = 0.0f;
				yDood += 0.07f;
			}
			else if (Input.GetKeyDown (KeyCode.A)) {
                SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
                SpeechText.GetComponent<TextMeshProUGUI>().enabled = true;
                SpeechText.GetComponent<TextMeshProUGUI>().SetText("West");
                xDood = 0.0f;
				yDood = 0.0f;
				xDood -= 0.07f;
			}
			else if (Input.GetKeyDown (KeyCode.S)) {
                SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
                SpeechText.GetComponent<TextMeshProUGUI>().enabled = true;
                SpeechText.GetComponent<TextMeshProUGUI>().SetText("South");
                xDood = 0.0f;
				yDood = 0.0f;
				yDood -= 0.07f;
			}
			else if (Input.GetKeyDown (KeyCode.D)) {
                SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
                SpeechText.GetComponent<TextMeshProUGUI>().enabled = true;
                SpeechText.GetComponent<TextMeshProUGUI>().SetText("East");
                xDood = 0.0f;
				yDood = 0.0f;
				xDood += 0.07f;
			}
			else if (Input.GetKeyDown (KeyCode.Space)) {
                SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
                SpeechText.GetComponent<TextMeshProUGUI>().enabled = true;
                SpeechText.GetComponent<TextMeshProUGUI>().SetText("STOP");
                xDood = 0.0f;
				yDood = 0.0f;
			}

            /*var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;*/

			if (xDood >= 0.07) {
				xDood = 0.07f;
			}
			if (xDood <= -0.07) {
				xDood = -0.07f;
			}
			if (yDood >= 0.07) {
				yDood = 0.07f;
			}
			if (yDood <= -0.07) {
				yDood = -0.07f;
			}

            transform.Translate(xDood, yDood, 0);
        }
    }
}
