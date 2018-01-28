using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public static int scoreVal = 0;
	public static int survivorCount = 50;
    public Text scoreText;
    
	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
		scoreText.text = "Survivors: " + survivorCount;

		if (survivorCount <= 0) {
			if (scoreVal >= 35) {
				win ();
			} else {
				lose ();
			}
		}
	
	}

	void win(){

	}

	void lose(){

	}
}
