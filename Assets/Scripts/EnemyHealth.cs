using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public static int enemiesKilled = 0;
    [SerializeField] EnemySO enemyObj;
    [SerializeField] private int startingHealth; // the starting health of the enemy
    public int currentHealth; // the current health of the enemy
  
    private void Start()
    {
        startingHealth = enemyObj._enemyHealth;
        currentHealth = startingHealth;

        Debug.Log("Starting health: " + startingHealth);
        Debug.Log("Current health: " + currentHealth);
    }

    public void TakeDamage()
    {
        currentHealth -= 1;

       
        if(currentHealth == 0)
        {
            Destroy(gameObject);
            enemiesKilled++;
            Debug.Log(enemiesKilled);
        }
    }

    public int CurrentHealth
    {
        get { return currentHealth; }
    }
}
