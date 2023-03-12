using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float damageAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            
            enemyHealth.TakeDamage(); 
            
            // reduce the enemy's health by a certain amount
            Destroy(gameObject);
        }
        

    }
}
