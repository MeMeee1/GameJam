using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
        public EnemySO enemySO;
        GameObject target;
        Rigidbody rb;
         Vector3 movement;

    private void Start() 
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update() 
    {
        Vector3 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        //rb.rotation = angle;
        direction.Normalize();
       movement = direction;
    }

     private void FixedUpdate() 
    {
        MoveCharacter(movement);
    }

    public void MoveCharacter(Vector3 direction)
    {
        rb.MovePosition(transform.position +(direction*enemySO._enemySpeed * Time.deltaTime));
    }
   public void Attack()
   {

   }
   
   public void TakeDamage(float damage)
   {
        damage -= enemySO._enemyHealth;
        if(enemySO._enemyHealth<=0)
        {
            Destroy(this.gameObject);
        }
   }
}
