using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    [SerializeField]
    private float speed;
    bool started;
    bool gameOver;
    Rigidbody rb;


    void Awake() {
        rb = GetComponent<Rigidbody>();
            }
	// Use this for initialization
	void Start () {
        started = false;
        gameOver = false;
	}
    // Update is called once per frame

    void Update() {
        if (!started)
        {
            if (Input.GetMouseButton(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
            }
        }
        Debug.DrawRay(transform.position, Vector3.down,Color.red);
        if (!Physics.Raycast(transform.position, Vector3.down, 1f)) {
            gameOver = true;
            rb.velocity = new Vector3(0, -25f, 0);
            Camera.main.GetComponent<CameraFollow>().gameOver = true;

        }
        if (Input.GetMouseButton(0) && !gameOver)
            {
                SwitchDirection();
            }
        
    }


    void SwitchDirection() {
        if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
        else if (rb.velocity.x > 0) {
            rb.velocity = new Vector3(0, 0, speed);
        }
    }
}
