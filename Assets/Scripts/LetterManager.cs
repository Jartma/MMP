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
    private GameObject letter;
    private BoxCollider2D ground;
    private bool[] letterBool;
    private int randomNumber;
    private bool instantiated;


    private void Awake() {
        
    }
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width, Screen.height, 0.0f));
        ground = GameObject.FindGameObjectWithTag("Ground").GetComponent<BoxCollider2D>();

        letterBool = new bool[letterPrefabs.Count];
        for(int i = 0; i < letterPrefabs.Count; i++){
            letterBool[i] = false;
        }
        instantiated = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        instantiated = false;
        
        counter += Time.deltaTime;
        //spawn a random letter 
        if (counter >= spawnTime) {
            counter = 0.0f;

            Vector2 spawnPos = new Vector2( Random.Range(-screenBounds.x, +screenBounds.x), screenBounds.y*1.5f);

            randomNumber = Random.Range(0, letterPrefabs.Count);

            while(instantiated != true){

                if(letterBool[randomNumber] == false){
                    letter = Instantiate(letterPrefabs[randomNumber]) as GameObject;
                    letter.transform.position = spawnPos;
                    letterBool[randomNumber] = true;
                    instantiated = true;
                }
                else if(letterBool[randomNumber]){
                    randomNumber = Random.Range(0, letterPrefabs.Count);

                    if(allLettersUsed()){
                        for(int i = 0; i < letterPrefabs.Count; i++){
                        letterBool[i] = false;
                        }
                        Debug.Log("all letters used");
                    }
                }
            }
        }
    }
    
     private bool allLettersUsed() {
        for ( int i = 0; i < letterBool.Length; ++i ) {
            if (letterBool[i] == false) {
            return false;
            }
        }
        return true;
    }
}
