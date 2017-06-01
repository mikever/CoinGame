using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    // Maximum time to complete level (in seconds)
    public static float MaxTime = 1000f;

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
        if (CountDown <= 0 && score < 135)
        {
            // Reset score and reload
            score = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (score >= 135)
        {
            // Teleport player to victory spot
            GameObject player = GameObject.Find("FPSController");
            player.transform.position = new Vector3(146, 39, -63);

            // Destroy timer and set off fireworks
            GameObject Timer = GameObject.Find("LevelTimer");
            Destroy(Timer);

            GameObject[] FireworkSystems =
                GameObject.FindGameObjectsWithTag("Fireworks");
            foreach (GameObject GO in FireworkSystems)
                GO.GetComponent<ParticleSystem>().Play();
        }
	}
}
