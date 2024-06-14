using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public GameObject enemiesPrefab;
    public float timer;
    public float spawnInterval = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            spawnEnemies();
            timer = 0f;
        }
           

            

    }
    void spawnEnemies()
    {
        float randomX = Random.Range(-10, 10f);
        Vector3 spawnPosition = new Vector3(randomX, 6f, 0);
        Instantiate(enemiesPrefab, spawnPosition, Quaternion.identity);
    }   
}
    