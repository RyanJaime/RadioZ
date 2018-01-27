﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour {

	// Use this for initialization
	public int clumpValue = 3;
	public float sense = 5.0f;
	//public GameObject allSurvivors;
	CircleCollider2D senseCircle;

	//wander values
	float duration = 5;  
	float elapsedTime = 0f; 
	float wait = 0f; 
	float waitTime = 0f; 

	float randomX;  
	float randomY ;
	bool move = true;

	//chase values

	public bool chasing = false;
	bool nearSurvivor = false;
	GameObject currentChaseVictim;



	void Start () {
		gameObject.AddComponent<CircleCollider2D> ();
		gameObject.AddComponent<Rigidbody2D> ();
		gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0;
		senseCircle = gameObject.GetComponent<CircleCollider2D> ();
		senseCircle.radius = sense;
		senseCircle.isTrigger = true;

		//random range of movement
		randomX = Random.Range(-3,3);
		randomY = Random.Range(-3,3);

		
	}
	
	// Update is called once per frame
	void Update () {

		/*
		var noise = allSurvivors.GetComponentsInChildren<CircleCollider2D> ();
		foreach (CircleCollider2D n in noise) {

		}
		*/
		if (!chasing){
			wander ();
		}
		
	}

	void OnTriggerStay2D(Collider2D coll){
		Debug.Log ("touching");
		if (coll.gameObject.tag == "Survivor") {

			if (!chasing){
				chasing = true;
				currentChaseVictim = coll.gameObject;
			}
			if (currentChaseVictim == coll.gameObject) {
				chase (coll.gameObject.transform.position);
			} 
		}

	}

	void OnTriggerExit2D(Collider2D coll){
		if (coll.gameObject == currentChaseVictim) {
			chasing = false;
			Debug.Log ("escaped");
		}

	}
		

		

	void wander(){
		if (elapsedTime < duration && move) {
			transform.Translate (new Vector3(randomX,randomY, 0.0f) * Time.deltaTime);
			elapsedTime += Time.deltaTime;

		} else if(move){
			move        = false;
			wait        = Random.Range (1, 3);
			waitTime    = 0f;
		}

		if (waitTime < wait && !move) {
			waitTime += Time.deltaTime;


		} else if(!move)  {
			move = true;
			elapsedTime = 0.0f;
			randomX = Random.Range (-3, 3);
			randomY = Random.Range (-3, 3);

		}
	}

	void chase(Vector3 pos){
		//chasing = true;
		Debug.Log("Chasing");
		//transform.Translate (pos * Time.deltaTime);
	}
}