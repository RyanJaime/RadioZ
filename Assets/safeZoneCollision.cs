using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safeZoneCollision : MonoBehaviour {

    public int maxCapacity;
    private int currentCapacity;

	// Use this for initialization
	void Start () {
        currentCapacity = 0;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        print("coLLLLLLliding");
        //if (coll.gameObject.tag == "Enemy")
        //    coll.gameObject.SendMessage("ApplyDamage", 10);

        if (coll.gameObject.tag == "Survivor" && currentCapacity < maxCapacity)
        {
            currentCapacity += 1;
            print("saved. current: " + currentCapacity + " max: " + maxCapacity);
            score.scoreVal -= 1;
            
            Destroy(coll.gameObject);
        }

    }
}
