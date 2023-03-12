using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class GunControl : MonoBehaviour
{
    [SerializeField]GameObject bulletPrefab;
    [SerializeField]Transform firePoint;
    [SerializeField]float bulletSpeed = 10;
    
    [SerializeField]AudioClip sfxClip;
    [SerializeField]AudioSource sfxSource;
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) {
                if(hit.collider.gameObject.CompareTag("Enemy"))
                {
                    transform.LookAt(hit.point);
                   
                    FireBullet();}
                
            }
        }
    }

    void FireBullet() {
        // Instantiate a bullet game object and set its position and rotation
        var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        // Add collision detection to the bullet
        bullet.GetComponent<Rigidbody>().velocity = firePoint.forward * bulletSpeed;
        sfxSource.PlayOneShot(sfxClip);
        
    
        
    }
}
