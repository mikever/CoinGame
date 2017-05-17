using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    //Keeps track of total coin count in scene
    public static int CoinCount = 0;

	// Use this for initialization
	void Start () {
        //Object created, increment coin count
        ++Coin.CoinCount;
	}
    
    void OnTriggerEnter(Collider Col)
    {
        //If player collected coin, then destroy object
        if (Col.CompareTag("Player"))
            Destroy(gameObject);
    }

    //Called when object destroyed
    void OnDestroy()
    {
        //Decrement coin count
        --Coin.CoinCount;

        //Check remaining coins
        if (Coin.CoinCount <= 0)
        {
            // Game is won. Collected all coins
            // Destroy timer and launch fireworks
            GameObject Timer = GameObject.Find("LevelTimer");
            Destroy(Timer);

            GameObject[] FireworkSystems =
                GameObject.FindGameObjectsWithTag("Fireworks");
            foreach (GameObject GO in FireworkSystems)
                GO.GetComponent<ParticleSystem>().Play();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
