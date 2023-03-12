using UnityEngine;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour
{
    
    
    [FancyHeader("  Enemy Manager  ", 1.5f, "blue", 5.5f, order = 0)]
    [SerializeField] Wave[] wave_to_Spawn;
   
    [SerializeField] GameEvent OnWaveStarted;
    public GameEvent OnEnemyHealthDamaged;
    public GameEvent OnGameWon;
    public static int totalEnemiesSpawned = 0;
    public bool allenemdead = false;
   
    public static EnemyManager instance;
   

     private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }

    private bool WaveEnded()
    {
        EnemyHealth[] enemies = FindObjectsOfType<EnemyHealth>();
        foreach (EnemyHealth enemy in enemies)
        {
            if (enemy.gameObject.activeInHierarchy)
            {
                return false;
            }
        }
        return true;
    }

    private void Update()
    {
       if (wave_to_Spawn[wave_to_Spawn.Length - 1].hasStarted == true && WaveEnded())
        {
            OnGameWon.Raise();
        } 
        
        foreach(Wave wave in wave_to_Spawn)
        {
            wave.Update();

            
            
            
            
        
            
            
             
        }
        
        

        
    }

    [System.Serializable]
    public class Wave
    {
        [FancyHeader(" Wave      ", 1.5f, "orange", 5.5f, order = 0)]
        public EnemySO[] enemytoSpawn;
        [SerializeField] float timer;
        [SerializeField] Transform[] spawnPoints;
        public int waveIndex;
        public int enemiesSpawned = 0;
        public bool hasStarted = false;
        //get the enemies health
        //reduce the health if bullet hits
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
            totalEnemiesSpawned++;
             enemiesSpawned++; 
            Debug.Log("EnemiesSpawned"+ enemiesSpawned);
            
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