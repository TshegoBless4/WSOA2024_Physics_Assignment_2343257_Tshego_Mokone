
using UnityEngine;

public class UImanager : MonoBehaviour
{
    [Header("Canvas")]
    public GameObject CanvasGame;
    public GameObject CanvasRestart;

    [Header ("CanvasRestart")]
    public GameObject WinTxt;
    public GameObject LoseTxt;

    public ScoreScript scoreScript;

    public PuckScript puckScript;
    public PlayerScript playerScript;
    public AiScript aiScript;

    public void ShowRestartCanvas(bool didAiWin)
    {
        Time.timeScale = 0;

        CanvasGame.SetActive(false);
        CanvasRestart.SetActive(true);

        if ( !didAiWin )
        {
            WinTxt.SetActive(false);
            LoseTxt.SetActive(true);
        }
        else if ( didAiWin ) 
        
        {
            WinTxt.SetActive(true);
            LoseTxt.SetActive(false);
        }

    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        CanvasGame.SetActive(true);
        CanvasRestart.SetActive(false);

        scoreScript.ResetScores();
        puckScript.CenterPuck();
        playerScript.ResetPosition();
        
        
    }
}
