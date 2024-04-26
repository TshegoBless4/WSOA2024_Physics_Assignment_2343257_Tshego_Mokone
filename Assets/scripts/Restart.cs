using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public int sceneId;
   
    public void RestartGame()
    {
        SceneManager.LoadScene(sceneId);
        Debug.Log(" its workingggggg");
       

    //    currentPanel.gameObject.SetActive(false);

    }
}
