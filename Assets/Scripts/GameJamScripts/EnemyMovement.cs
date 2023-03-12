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
        if (GameManager.instance.StartGame == true)
        {
            if(!collidedWithWall || !collidedWithWall)
            {
                transform.Translate(Vector3.forward * enemySO._enemySpeed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("wall") || collision.gameObject.CompareTag("Enemy"))
        {
            collidedWithWall = true;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            collidedWithEnemy = true;
            
=======
=======
>>>>>>> c164d3e6dd368504e9ec4a12f1cf7d51f868273a
=======
>>>>>>> c164d3e6dd368504e9ec4a12f1cf7d51f868273a
            if(anim!=null)
            {
                 anim.SetBool("isAttacking",true);
            }
           
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> c164d3e6dd368504e9ec4a12f1cf7d51f868273a
=======
>>>>>>> c164d3e6dd368504e9ec4a12f1cf7d51f868273a
=======
>>>>>>> c164d3e6dd368504e9ec4a12f1cf7d51f868273a
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            PlayerHealth.instance.TakeDamage();
            PlayerHealth.instance.OnPlayerHealthDamage.Raise();
        }

    }
    
}
