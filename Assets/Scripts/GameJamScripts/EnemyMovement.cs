using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public EnemySO enemySO;
    
    
    Rigidbody rb;
    private bool collidedWithWall = false;
    private bool collidedWithEnemy = false;
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
      
            anim = GetComponent<Animator>();
           
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
            if(anim!=null)
            {
                 anim.SetBool("isAttacking",true);
            }
           
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            PlayerHealth.instance.TakeDamage();
            PlayerHealth.instance.OnPlayerHealthDamage.Raise();
        }

    }
    
}
