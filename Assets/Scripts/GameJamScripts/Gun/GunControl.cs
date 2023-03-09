using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    [SerializeField]GameObject bulletPrefab;
    [SerializeField]Transform firePoint;
    [SerializeField]float bulletSpeed = 10;
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) {
                transform.LookAt(hit.point);
                    FireBullet();
                
            }
        }
    }

    void FireBullet() {
        // Instantiate a bullet game object and set its position and rotation
        var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        // Add collision detection to the bullet
        bullet.GetComponent<Rigidbody>().velocity = firePoint.forward * bulletSpeed;
        
    
        // Destroy the enemy game object when the bullet hits it
    }
}
