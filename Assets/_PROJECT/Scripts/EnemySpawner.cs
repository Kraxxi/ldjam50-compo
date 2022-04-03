using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public int maxEnemies;
    
    public float spawnInterval;

    public List<GameObject> spawnedEnemies;
    public List<GameObject> enemyPrefabs;

    public bool spawning;
    
    public float elapsedTime;

    public float maxSpawnX;
    public float minSpawnX;

    public float maxSpawnY;
    public float minSpawnY;

    public float minTargetY;
    public float maxTargetY;
    

    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private void Update()
    {
        elapsedTime = Time.time;

        maxEnemies = (int) (elapsedTime / 10) + 1;
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            if (spawning)
            {
                Vector3 spawnPos = new Vector3(Random.Range(minSpawnX, maxSpawnX), Random.Range(minSpawnY, maxSpawnY), 0f);
                
                yield return new WaitForSeconds(spawnInterval);

                for (int i = spawnedEnemies.Count - 1; i >= 0; i--)
                {
                    if (spawnedEnemies[i] == null)
                    {
                        spawnedEnemies.RemoveAt(i);
                    }
                }
                
                if (spawnedEnemies.Count < maxEnemies)
                {
                    GameObject enemy = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Count)], spawnPos, transform.rotation);
                    MoveToYPosition moveToYPosition = enemy.GetComponent<MoveToYPosition>();
                    moveToYPosition.targetY = Random.Range(minTargetY, maxTargetY);
                    spawnedEnemies.Add(enemy);
                    
                }
            }
        }
    }
}
