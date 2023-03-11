using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] EnemySO enemyObj;
    [SerializeField] private int startingHealth; // the starting health of the enemy
    public int currentHealth; // the current health of the enemy
    private void Awake()
    {
        startingHealth = enemyObj._enemyHealth;
    }
    private void Start()
    {
        startingHealth = enemyObj._enemyHealth;
        currentHealth = startingHealth;

        Debug.Log("Starting health: " + startingHealth);
        Debug.Log("Current health: " + currentHealth);
    }

    public void TakeDamage()
    {
        currentHealth -= enemyObj._enemyDamage;

       
        if(currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    public int CurrentHealth
    {
        get { return currentHealth; }
    }
}
