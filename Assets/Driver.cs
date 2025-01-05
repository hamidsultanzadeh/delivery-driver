using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300;
    [SerializeField] float moveSpeed = 20;
    [SerializeField] float slowSpeed = 30;
    [SerializeField] float boostSpeed = 20;

    // OnTriggerEnter for boosting speed, moveSpeed = boostSpeed;
    // OnCollisionEnter for slowing speed, moveSpeed = slowSpeed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
