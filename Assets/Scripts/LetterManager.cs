using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using Random = UnityEngine.Random;

public class LetterManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private List<GameObject> letterPrefabs;
    [SerializeField] private float spawnTime = 20.0f;
    private float counter = 0.0f;
    private Vector2 screenBounds;

    //private GameObject H;
    //private GameObject E;
    //private GameObject Y ;

    private GameObject letter;
    private BoxCollider2D ground;


    private void Awake() {
        
    }
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width, Screen.height, 0.0f));
        ground = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
        counter += Time.deltaTime;
        //spawn a random letter 
        if (counter >= spawnTime) {
            counter = 0.0f;

            Vector2 spawnPos = new Vector2( Random.Range(-screenBounds.x, +screenBounds.x), screenBounds.y*1.5f);

            letter = Instantiate(letterPrefabs[Random.Range(0, letterPrefabs.Count)]) as GameObject;

            letter.transform.position = spawnPos;     
        }   
    }
}
