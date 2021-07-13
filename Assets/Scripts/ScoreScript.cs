using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue;
    public static int score;
    
    
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 10;
        scoreValue = 0;
        //StartCoroutine(ScoreUpdater());
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreValue.ToString();
    }

    /*private IEnumerator ScoreUpdater()
    {
        while (true)
        {
            if (scoreValue < score)
            {
                scoreValue+=10;
                scoreText.text = scoreValue.ToString();
            }

            yield return new WaitForSeconds(0.2f);
        }
    }*/
}
