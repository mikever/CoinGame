using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    // Maximum time to complete level (in seconds)
    public float MaxTime = 300f;

    //Countdown
    [SerializeField]
    private float CountDown = 0;

	// Use this for initialization
	void Start () {
        CountDown = MaxTime;
	}
	
	// Update is called once per frame
	void Update () {
        // Reduce time
        CountDown -= Time.deltaTime;

        // Restart level if time runs out
        if (CountDown <= 0)
        {
            // Reset coin count
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
