using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField]
    float speed;

    Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        if (rigidbody.velocity.magnitude <3.5f)
        {
            rigidbody.AddForce(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
