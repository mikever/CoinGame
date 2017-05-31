using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //log message for my own tracking
        Debug.Log("Portal Stone Created");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider Col)
    {
        //debug message letting me know I touched object
        Debug.Log("You touched the stone");

        Col.transform.position = new Vector3(-15.61f, 17.34f, 0);
    }
}
