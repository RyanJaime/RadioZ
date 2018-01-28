using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
                scoreVal = 0;
                survivorCount = 50;
				win ();
			} else {
                scoreVal = 0;
                survivorCount = 50;
                lose ();
			}
		}
	
	}

	void win(){
		SceneManager.LoadScene ("win");
	}

	void lose(){
		Application.LoadLevel ("lose");
	}
}
