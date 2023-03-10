using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
        public EnemySO enemySO;
         public GameObject target;
        Rigidbody rb;
         Vector3 movement;

    private void Start() 
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update() 
    {
        Vector3 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y,direction.x)* Mathf.Rad2Deg;
        //rb.rotation = angle;
        //direction.normalize;
      //  movement = direction;
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
}
