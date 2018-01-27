using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieHitbox : MonoBehaviour {
	BoxCollider2D hitbox;

	// Use this for initialization
	void Start () {
		gameObject.AddComponent<BoxCollider2D> ();
		gameObject.AddComponent<Rigidbody2D> ();
		gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0;

		hitbox = gameObject.GetComponent<BoxCollider2D> ();
		hitbox.size = new Vector2 (3.0f,3.0f);


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.tag == "Survivor Hitbox"){
			convert (coll);
		}

	}

	void convert(Collision2D C){
		gameObject.GetComponentInParent<zombie> ().chasing = false;
		var survivorPos = C.gameObject.transform.position;
		Destroy (C.gameObject);
		//insert creation of new zombie here
		GameObject newZom = new GameObject();
		newZom.AddComponent<zombie> ();
		GameObject newZomHitbox = new GameObject ();
		newZomHitbox.transform.parent = newZom.transform;
		newZom.transform.position = survivorPos;

	}
}
