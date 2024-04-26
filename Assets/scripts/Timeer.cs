using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeer : MonoBehaviour
{
    [SerializeField] private float currentTime = 5;
    [SerializeField] private Text timerText;
    [SerializeField] private GameObject timerPanel;
    [SerializeField] private GameObject gameplayPanel;

    private void Start()
    {
        timerText.text = "Timer : " + currentTime.ToString(); // Use Mathf.CeilToInt to round up currentTime
    }

    public void Update()
    {
        CountdownTimer();//callss the timer method evryt frame
    }

    private void CountdownTimer()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            timerText.text = "Timer : " + Mathf.CeilToInt(currentTime).ToString(); // Update the timer text
           
        }
        else
        {
            Debug.Log("Timer has run out");
            timerPanel.SetActive(false); // Set the timer panel inactive
            gameplayPanel.SetActive(true); // Set the gameplay panel active
        }
    }
}
