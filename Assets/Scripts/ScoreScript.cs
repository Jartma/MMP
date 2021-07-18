using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue;
    public static int score;
    public static int scoreL1, scoreL2, scoreL3, scoreL4;
    
    
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 10;
        scoreL1 = 50;
        scoreL2 = 100;
        scoreL3 = 150;
        scoreL4 = 200;
        
        if(SceneManager.GetActiveScene().name == "Level 1"){
            scoreValue = 0;
        }
        
        if (scoreValue == 0)
        {
            scoreValue = 0;
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreValue.ToString();
    }
    
}
