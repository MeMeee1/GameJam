using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    Quaternion rotation = Quaternion.LookRotation(dir, Vector3.forward);
    transform.rotation = rotation;}
}