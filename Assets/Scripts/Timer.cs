using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float timeRemaining = 600;
    public bool timerIsRunning = false;
    public Text timeText;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Level 1"){
            timeRemaining = 600;
        }
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time is over!");
                timeRemaining = 0;
                timerIsRunning = false;
                StartCoroutine(loadGameOverScreen());
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

      IEnumerator loadGameOverScreen()
    {
        yield return new WaitForSeconds(seconds: 1);
        SceneManager.LoadScene("Menu Screen/GameOverMenu");
    }
}