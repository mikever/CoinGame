using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp_script2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //log message for my own tracking
        Debug.Log("Portal Stone Created");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider Col)
    {
        //debug message letting me know I touched object
        Debug.Log("You touched the stone");

        Col.transform.position = new Vector3(-77.68f, 8, -112.2f);
    }
}
