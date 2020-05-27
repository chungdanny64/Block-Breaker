using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;
    private bool HasStarted = false;
    private Vector3 PaddleToBallVector;
	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        PaddleToBallVector = this.transform.position - paddle.transform.position;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (!HasStarted)
        {
            this.transform.position = paddle.transform.position + PaddleToBallVector;
            if (Input.GetMouseButtonDown(0))
            {
                print("Mouse clicked");
                HasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 10f);
            }
        }
	}
}
