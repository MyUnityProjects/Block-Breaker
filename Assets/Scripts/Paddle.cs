using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public bool autoPlay = false;

    public Ball ball;



	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<Ball>(); // this finds the ball in the scene
    }
	
	// Update is called once per frame
	void Update () {

        if(!autoPlay)
        {
            MoveWithMouse();
        } else
        {
            AutoPlay();
        }
	}

    void MoveWithMouse()
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f); //sets the basic position of the paddle

        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16; // sets the size of the screen per world units

        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f); //prevents paddle from moving outside of map *can also use colliders for that
        this.transform.position = paddlePos; // sets the movement of the curser to match the the movement of the paddle

        //print(mousePosInBlocks);
    }

    void AutoPlay() // changes the controller of the paddle to automatic insted of controlled by player
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f); //sets the basic position of the paddle

        Vector3 ballPos = ball.transform.position;

        paddlePos.x = Mathf.Clamp(ballPos.x, 0.5f, 15.5f); //prevents paddle from moving outside of map *can also use colliders for that
        this.transform.position = paddlePos; // sets the movement of the curser to match the the movement of the paddle

        //print(mousePosInBlocks);
    }
}
