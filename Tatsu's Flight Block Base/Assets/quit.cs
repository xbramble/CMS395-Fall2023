using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{
    public void QuitGame()
    {
        // Load the main game scene
        Application.Quit();
    } 

    public void replay()
    {
        SceneManager.LoadScene("1");
    }
}

