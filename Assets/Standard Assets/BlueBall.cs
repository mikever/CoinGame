using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider Col)
    {
        //If player collects object, then destroy object
        if (Col.CompareTag("Player"))
        {
            Timer.CountDown = Timer.CountDown + 5;
            Timer.score = Timer.score + 25;
            Destroy(gameObject);
        }

    }

    //Called when object destroyed
    void OnDestroy()
    {

        //Check remaining time and score

    }

    // Update is called once per frame
    void Update()
    {

    }
}
