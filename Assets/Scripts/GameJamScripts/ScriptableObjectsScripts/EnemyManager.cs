using UnityEngine;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour
{
    
    
    [FancyHeader("  Enemy Manager  ", 1.5f, "blue", 5.5f, order = 0)]
    [SerializeField] Wave[] wave_to_Spawn;
    [SerializeField]int currentIndex;
    [SerializeField] IntEvent OnWaveStarted;
    
    private void Update()
    {
        foreach(Wave wave in wave_to_Spawn)
        {
            wave.Update();

            if (wave.hasStarted)
            {
                currentIndex++;
                Debug.Log(currentIndex);
                OnWaveStarted.Raise(currentIndex);
                
                
                
                wave.hasStarted = false;
            }
            
        }
    }

    [System.Serializable]
    public class Wave
    {
        [FancyHeader(" Wave      ", 1.5f, "orange", 5.5f, order = 0)]
        [SerializeField] EnemySO[] enemytoSpawn;
        [SerializeField] float timer;
        [SerializeField] Transform[] spawnPoints;
        public int waveIndex;

        public bool hasStarted = false;

        public void Update()
        {
            if(timer >= 0)
            {
                timer -= Time.deltaTime;
                if(timer <= 0)
                {
                    hasStarted = true;
                    SpawnEnemy();
                }
            }
        }
    public void SpawnEnemy()
{
    int spawnPointCount = spawnPoints.Length;
    int enemyCount = enemytoSpawn.Length;
    int spawnPerEnemy = Mathf.CeilToInt((float)spawnPointCount / enemyCount); // calculate how many spawn points each enemy should occupy
    int remainingSpawns = spawnPointCount;
    List<Transform> usedSpawnPoints = new List<Transform>();

    for (int i = 0; i < enemyCount; i++)
    {
        int spawnsToTake = Mathf.Min(remainingSpawns, spawnPerEnemy); // take the remaining spawns or the desired amount, whichever is smaller
        List<Transform> availableSpawnPoints = new List<Transform>(spawnPoints);
        availableSpawnPoints.RemoveAll(x => usedSpawnPoints.Contains(x)); // remove any used spawn points from the available list
        for (int j = 0; j < spawnsToTake; j++)
        {
            int spawnIndex = Random.Range(0, availableSpawnPoints.Count);
            Transform spawnPoint = availableSpawnPoints[spawnIndex];
            Instantiate(enemytoSpawn[i]._enemyPrefab, spawnPoint.position, Quaternion.identity);
            availableSpawnPoints.RemoveAt(spawnIndex);
            usedSpawnPoints.Add(spawnPoint);
        }
        remainingSpawns -= spawnsToTake;
    }
}

}}