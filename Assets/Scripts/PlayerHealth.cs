using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3; // the maximum health of the player
    [SerializeField] PlayerSO _player;
    private int currentHealth; // the current health of the player
    [SerializeField]GameEvent OnGameLost;
    public static PlayerHealth instance;

    private void Awake()
    {
        if (instance == null)
        {   instance = this;}
        maxHealth = _player._playerHealth;
    }
    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage()
    {
        currentHealth -= _player._playerDamage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // handle player death here
        Time. timeScale = 0;
        OnGameLost.Raise();
    }
}
