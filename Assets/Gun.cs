using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    public float minRotation = 0.0f;
    public float maxRotation = 180.0f;
    private float currentRotation = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         float rotationInput = Input.GetAxis("Horizontal");
         currentRotation+=rotationInput*rotationSpeed*Time.deltaTime;
         transform.rotation = Quaternion.Euler(currentRotation,0.0f, 0.0f);
    }
}
