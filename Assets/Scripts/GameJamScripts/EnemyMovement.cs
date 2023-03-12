using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public EnemySO enemySO;
    
    
    Rigidbody rb;
    private bool collidedWithWall = false;
    private bool collidedWithEnemy = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (!collidedWithWall)
        {
            transform.Translate(Vector3.forward * enemySO._enemySpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            collidedWithWall = true;
            
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            PlayerHealth.instance.TakeDamage();
            PlayerHealth.instance.OnPlayerHealthDamage.Raise();
        }

    }
    
}
