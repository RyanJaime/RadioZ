using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieHitbox : MonoBehaviour {
	BoxCollider2D hitbox;
	public Sprite z;
	GameObject ZombieSprites;


	// Use this for initialization
	void Awake () {
		//gameObject.AddComponent<BoxCollider2D> ();
		//gameObject.AddComponent<Rigidbody2D> ();
		//gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0;


		hitbox = gameObject.GetComponent<BoxCollider2D> ();


		ZombieSprites = GameObject.FindGameObjectWithTag("Zombie Handler");
		if (gameObject.GetComponentInParent<zombie> ().clumpValue == 3) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = ZombieSprites.GetComponent<Zsprites> ().z3;
		} else if (gameObject.GetComponentInParent<zombie> ().clumpValue == 7) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = ZombieSprites.GetComponent<Zsprites> ().z7;

		} else {
			gameObject.GetComponent<SpriteRenderer> ().sprite = ZombieSprites.GetComponent<Zsprites> ().z10;

		}
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
		var survivorNum = C.gameObject.GetComponent<controls> ().groupSize;
		score.survivorCount -= survivorNum;
		Destroy (C.gameObject);
		//insert creation of new zombie here
		GameObject newZom = new GameObject();
		newZom.AddComponent<zombie> ();

		newZom.transform.position = survivorPos;

		GameObject newZomHitbox = new GameObject ();
		newZomHitbox.AddComponent<zombieHitbox> ();
		newZomHitbox.AddComponent<SpriteRenderer>();
		if (survivorNum == 3) {
			newZomHitbox.GetComponent<SpriteRenderer> ().sprite = ZombieSprites.GetComponent<Zsprites> ().z3;
			newZom.GetComponent<zombie> ().clumpValue = 3;

		} else if (survivorNum == 7) {
			newZomHitbox.GetComponent<SpriteRenderer> ().sprite = ZombieSprites.GetComponent<Zsprites> ().z7;
			newZom.GetComponent<zombie> ().clumpValue = 7;

		} else {
			newZomHitbox.GetComponent<SpriteRenderer> ().sprite = ZombieSprites.GetComponent<Zsprites> ().z10;
			newZom.GetComponent<zombie> ().clumpValue = 10;

		}
		//newZomHitbox.GetComponent<SpriteRenderer> ().sprite = z;
		//newZomHitbox.GetComponent<zombieHitbox> ().z = z;
		newZomHitbox.AddComponent<BoxCollider2D> ();
		newZomHitbox.transform.position = newZom.transform.position;
		newZomHitbox.transform.parent = newZom.transform;

	}
}
