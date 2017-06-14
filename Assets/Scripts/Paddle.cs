using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f); //sets the basic position of the block

        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16; // sets the size of the screen per world units

        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f); //prevents paddle from moving outside of map *can also use colliders for that
        this.transform.position =  paddlePos; // sets the movement of the curser to match the the movement of the paddle

        print(mousePosInBlocks);
	}
}
