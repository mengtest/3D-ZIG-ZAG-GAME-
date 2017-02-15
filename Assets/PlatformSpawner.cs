using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this is a gameObject
public class PlatformSpawner : MonoBehaviour {

    public GameObject platform;//the platform we want to spawn
    Vector3 lastPos;//the last position where our platform was
    float size; //the size of our platform.We need the size to colculate the new position.
	// Use this for initialization
	void Start () {
        lastPos = platform.transform.position;
        size = platform.transform.localScale.x;//we have same size on x and z.
        for(int i = 0; i < 5; i++) { SpawnX(); }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    //tis functions are responsable to spawn the platform in the x,z directions
    void SpawnX() {
        Vector3 pos = lastPos;
        pos.x += size;
        lastPos = pos;
        Instantiate(platform, pos, Quaternion.identity);//instantiate the platform in the pos position with no rotation
    }
    void SpawnZ() { }
}
