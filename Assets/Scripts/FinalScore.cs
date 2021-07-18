using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public static int finalScore; 
    private Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
       finalScore = ScoreScript.scoreValue;
       scoreText = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + finalScore.ToString();
    }
}
