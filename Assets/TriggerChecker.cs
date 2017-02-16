using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Ball")//if the object who exits from the collider has a tag=="Ball"
        {
            Invoke("FallDown", 0.5f);  //invoke the function FallDown() after 0.5sec      
        }          
    }
    void FallDown() {
        GetComponentInParent<Rigidbody>().useGravity=true;
        GetComponentInParent<Rigidbody>().isKinematic = false;//isKinematic property makes an object stay in its position 
        Destroy(transform.parent.gameObject, 2f);
    }
}
