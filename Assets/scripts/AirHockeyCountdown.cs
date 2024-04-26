using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AirHockeyCountdown : MonoBehaviour
{
    public Text countdownText;
    public float countdownDuration = 5f;

    void Start()
    {
        // Start the countdown coroutine when the game starts
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        float timeRemaining = countdownDuration;

        // Countdown loop
        while (timeRemaining > 0)
        {
            // Update the time remaining
            timeRemaining -= Time.deltaTime;

            // Update the countdown text
            countdownText.text = Mathf.CeilToInt(timeRemaining).ToString();

            // Wait for the next frame
            yield return null;
        }

        // Countdown has finished
        countdownText.text = "GO!";
        // Add code here to start the air hockey game
    }
}
