using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject startPanel;
    

    private void Start()
    {
        Time.timeScale = 1.0f;

    }
    public void PausesGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        startPanel.gameObject.SetActive(false);
    }
}
