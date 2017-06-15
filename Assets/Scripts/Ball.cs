using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Paddle paddle;

    private bool hasStarted = false;  //initialized to false because game hasent started

    private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();

        paddleToBallVector = this.transform.position - paddle.transform.position; // sets the location of the ball to be on paddle
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            //lock the ball relative to the paddle
            this.transform.position = paddle.transform.position + paddleToBallVector; //sets location of ball on paddle every frame
        }

        //wait for a mouse click to launch
        if (Input.GetMouseButtonDown(0)) //basiclly on click
        {
            print("mouse clicked");
            hasStarted = true; // on click means that the game has started
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f); //new syntax for rigidbody give it an initial velocity with the vector 2 property
        }
	}
}
