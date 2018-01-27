using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public static int scoreVal = 3;
    public Text scoreText;
    
	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        scoreText.text = "Survivors: " + scoreVal;
	}
}
