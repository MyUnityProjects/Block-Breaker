using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoseCollider : MonoBehaviour {

    private LevelManager levelManager;


    void OnTriggerEnter2D (Collider2D trigger)
    {
       // print("Trigger");
        levelManager.LoadLevel("Lose");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // print("Collider");
        
    }

	// Use this for initialization
	void Start () {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
