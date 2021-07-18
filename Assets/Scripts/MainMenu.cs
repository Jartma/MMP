using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        ScoreScript.scoreValue = 0;
        SceneManager.LoadScene("Levels/Level 1");
    }
    public void QuitGame()
    {
        Application.Quit(); 
    }
}