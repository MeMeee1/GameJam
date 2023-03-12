using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3; // the maximum health of the player
    [SerializeField] PlayerSO _player;
    private int currentHealth; // the current health of the player
    [SerializeField]GameEvent OnGameLost;
    public GameEvent OnPlayerHealthDamage;
    public static PlayerHealth instance;

    public Image healthBarImage;

    private void Awake()
    {
        if (instance == null)
        {   instance = this;}
        
    }
    private void Start()
    {
        maxHealth = _player._playerHealth;
        currentHealth = maxHealth;
    }

    public void TakeDamage()
    {
        currentHealth -= _player._playerDamage;

        if (currentHealth <= 0)
        {
            Die();
        }
        float fillAmount = (float)currentHealth / (float)maxHealth;

        // update the fill amount of the image component
        healthBarImage.fillAmount = fillAmount;
    }

    private void Die()
    {
        // handle player death here
       
        OnGameLost.Raise();
    }
}
