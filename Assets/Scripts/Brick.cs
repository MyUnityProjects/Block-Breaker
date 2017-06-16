using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private LevelManager levelManager;

    bool isBreakable;

    private int timesHit;
    public AudioClip crack;
    public Sprite[] hitSprites;

    public static int breakableCount = 0;

    // Use this for initialization
    void Start () {
        isBreakable = (this.tag == "Breakable");
        //keep track of breakable bricks 
        if (isBreakable)
        {
            breakableCount++;
            print("breakableCount: " + breakableCount);
        }
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //on collision
    void OnCollisionEnter2D(Collision2D collision)
    {
       
        
        if (isBreakable)
        {
            HandleHits();
        }
    }

    void HandleHits()
    {
        int maxHits;
        maxHits = hitSprites.Length + 1;
        // print("Collider");
        timesHit++;
        if (timesHit >= maxHits)
        {
            breakableCount--;
            levelManager.brickDestroyed();
            print("breakableCount: " + breakableCount);
            Destroy(gameObject);
            
        }
        else
        {
            LoadSprites();
        }
    }

    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex])
        {
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }

    //TODO remove simulate method once we can actually win
    void SimulateWin() {

        levelManager.LoadNextLevel();
    }
}


