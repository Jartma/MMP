using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnergyManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> energyPrefabs;
    [SerializeField] private float spawnTime = 1.0f;
    private float counter = 0.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f));
        //letter = GameObject.FindGameObjectWithTag("Letter").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //spawn a heart/energy every x seconds somewhere within the screen bounds
        counter += Time.deltaTime;

        if (counter >= spawnTime)
        {
            counter = 0.0f;
            
            Vector2 spawnPos = new Vector2(-screenBounds.x*1.5f, Random.Range(-screenBounds.y, +screenBounds.y));

            GameObject energy = Instantiate<GameObject>(energyPrefabs[0]);
            energy.transform.position = spawnPos;
        }
    }
    
}
