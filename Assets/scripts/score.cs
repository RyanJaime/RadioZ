using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class score : MonoBehaviour {
    public static int scoreVal = 0;
	public static int survivorCount = 50;
    public TextMeshProUGUI scoreText;
     
    
	// Use this for initialization
	void Start () {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update () {
		scoreText.text = "Survivors:\n" + survivorCount + "\nScore:\n" + scoreVal;

		if (survivorCount <= 0) {
			if (scoreVal >= 25) {
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
