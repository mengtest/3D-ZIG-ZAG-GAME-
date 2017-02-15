using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject ball;
    Vector3 offset;//distance between camera and ball
    public float lerpRate;//tis is the rate by wich the camera will change its position to follow the ball
    public bool gameOver;
	// Use this for initialization
	void Start () {
        offset = ball.transform.position - transform.position;//position of the ball-position of the camera
        gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!gameOver) {
            follow();
        }
	}
    void follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetPos = ball.transform.position - offset;
        pos=Vector3.Lerp(pos, targetPos, lerpRate * Time.deltaTime);
        transform.position = pos;
    }
}
