using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private LevelManager levelManager;
    public int maxHits;
    private int timesHit;

    // Use this for initialization
    void Start () {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //on collision
    void OnCollisionEnter2D(Collision2D collision)
    {
       // print("Collider");
        timesHit++;
        if(timesHit >= maxHits)
        {
            Destroy(gameObject);
        }
        
    }
    //TODO remove simulate method once we can actually win
    void SimulateWin() {

        levelManager.LoadNextLevel();
    }
}


