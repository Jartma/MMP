using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    }

    // Update is called once per frame
    void Update()
    {
        //spawn an asteroid every x seconds somewhere within the screen bounds
        counter += Time.deltaTime;

        if (counter >= spawnTime)
        {
            counter = 0.0f;
            
            //1.5f sieht man das aufploppen nicht
            //Vector2 spawnPos = new Vector2(Random.Range(-screenBounds.x, +screenBounds.x), screenBounds.y*1.5f);
            Vector2 spawnPos = new Vector2(-screenBounds.x*1.5f, Random.Range(-screenBounds.y, +screenBounds.y));

            GameObject energy = Instantiate<GameObject>(energyPrefabs[0]);
            energy.transform.position = spawnPos;
        }
    }
}
