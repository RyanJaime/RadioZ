using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieHitbox : MonoBehaviour {
	BoxCollider2D hitbox;
	public Sprite z;

	// Use this for initialization
	void Start () {
		//gameObject.AddComponent<BoxCollider2D> ();
		//gameObject.AddComponent<Rigidbody2D> ();
		//gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0;


		hitbox = gameObject.GetComponent<BoxCollider2D> ();
		//hitbox.size = new Vector2 (1.0f,1.0f);


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay2D (Collision2D coll){
		//Debug.Log (coll.gameObject.name);
		if (coll.gameObject.tag == "Survivor"){
			convert (coll);
			Debug.Log ("convert");
		}

	}

	void convert(Collision2D C){
		gameObject.GetComponentInParent<zombie> ().chasing = false;
		var survivorPos = C.gameObject.transform.position;
		Destroy (C.gameObject);
		//insert creation of new zombie here
		GameObject newZom = new GameObject();
		newZom.AddComponent<zombie> ();

		newZom.transform.position = survivorPos;

		GameObject newZomHitbox = new GameObject ();
		newZomHitbox.AddComponent<zombieHitbox> ();
		newZomHitbox.AddComponent<SpriteRenderer>();
		newZomHitbox.GetComponent<SpriteRenderer> ().sprite = z;
		newZomHitbox.GetComponent<zombieHitbox> ().z = z;
		newZomHitbox.AddComponent<BoxCollider2D> ();
		newZomHitbox.transform.position = newZom.transform.position;
		newZomHitbox.transform.parent = newZom.transform;

	}
}
