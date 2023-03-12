using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] EnemySO enemyObj;
    [SerializeField] private int startingHealth; // the starting health of the enemy
    public int currentHealth; // the current health of the enemy

    public static EnemyHealth instance;
    public int totalNum;
    public Image healthBarImage; // reference to the image component

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    private void Start()
    {
        startingHealth = enemyObj._enemyHealth;
        currentHealth = startingHealth;
    }

    public void TakeDamage()
    {
        currentHealth -= 1;

        if (currentHealth == 0)
        {

            Destroy(gameObject);

        }

        // calculate the fill amount based on the current health
        float fillAmount = (float)currentHealth / (float)startingHealth;

        // update the fill amount of the image component
        healthBarImage.fillAmount = fillAmount;
    }

    public int CurrentHealth
    {
        get { return currentHealth; }
    }
}
