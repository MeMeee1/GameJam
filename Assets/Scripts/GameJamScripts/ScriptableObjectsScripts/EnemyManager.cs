using UnityEngine;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
// Date updated: " + DateTime.Now.ToString("MM/dd/yyyy")
[CreateAssetMenu(fileName = "Managers/EnemyManager", menuName = "EnemyManager")]
public class EnemyManager : MonoBehaviour
{
    [FancyHeader("  Enemy Manager  ", 1.5f, "blue", 5.5f, order = 0)]
    [SerializeField] EnemySO enemyObjects;
    [SerializeField] Transform[] spwanPoints;
    public void SpawnEnemy()
    {
       foreach (Transform _spwanPoint in spwanPoints)
       {
            Instantiate(enemyObjects._enemyPrefab, _spwanPoint.position, Quaternion.identity,transform);
       }
    }
}