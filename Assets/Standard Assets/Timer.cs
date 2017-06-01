using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    // Maximum time to complete level (in seconds)
    public static float MaxTime = 45f;

    //Countdown
    [SerializeField]
    public static float CountDown = 0;

    //Score
    public static int score = 0;

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
            // Reset score and reload
            score = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
