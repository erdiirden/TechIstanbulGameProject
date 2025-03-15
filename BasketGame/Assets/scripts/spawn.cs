using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public AudioSource start;
    float leftSpawnBoundary = -1.19f;
    float rightSpawnBoundary = 1.19f;
    float upSpawnBoundary = -2.4f;
    public GameObject[] fruits;
    float spawnDuraction = 3f;
    float timer = 0f;
    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnDuraction)
        {
            SpawnRandomFruit();
            timer = 0f;
        }
    }

    void SpawnRandomFruit()
    {
        if(gameOver.isGame==false)
        {
            start.Play();
            if (fruits.Length == 0) return;
            Vector3 spawnPosition = new Vector3(Random.Range(leftSpawnBoundary, rightSpawnBoundary), 0.29f, upSpawnBoundary);
            GameObject randomFruit = fruits[Random.Range(0, fruits.Length)];
            Instantiate(randomFruit, spawnPosition, Quaternion.identity);

        }
        
    }
}
