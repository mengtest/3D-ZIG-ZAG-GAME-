using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this is a gameObject
public class PlatformSpawner : MonoBehaviour {

    public GameObject platform;//the platform we want to spawn
    Vector3 lastPos;//the last position where our platform was
    float size; //the size of our platform.We need the size to colculate the new position.
    public bool gameOver;
    // Use this for initialization
	void Start () {
        lastPos = platform.transform.position;
        size = platform.transform.localScale.x;//we have same size on x and z.
        for (int i = 0; i < 20; i++) { SpawnPlatforms(); }
        InvokeRepeating("SpawnPlatforms", 2f, 0.2f);//calls SpawnPlatforms after 2 sec and each 0.2 sec after the first call
    }
	
	// Update is called once per frame
	void Update () {
        if (gameOver) { CancelInvoke("SpawnPlatforms"); }//cancel invokeRepeating for SpawnPlatforms()
    }
    //let's create a function that call SpawnX and SpawnZ randomly
    void SpawnPlatforms()
    {
        if (gameOver) { return; }
        int rand= Random.Range(0,6);//returns a random float number between 0 and 5
        if (rand < 3) {
            SpawnX();
        }
        else if (rand >= 3)
        {
            SpawnZ();
        }
    }
    //tis functions are responsable to spawn the platform in the x,z directions
    void SpawnX() {
        Vector3 pos = lastPos;
        pos.x += size;
        lastPos = pos;
        Instantiate(platform, pos, Quaternion.identity);//instantiate the platform in the pos position with no rotation
    }
    void SpawnZ() {
        Vector3 pos = lastPos;
        pos.z += size;
        lastPos = pos;
        Instantiate(platform, pos, Quaternion.identity);//instantiate the platform in the pos position with no rotation
    }
}
