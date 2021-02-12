using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{   
    float speed = 350;

    Rigidbody rigidbody;

    bool move;
   

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        move = false;
    }
    

    void Update()
    {
        CheckTouch();
        
        if (move)
        {
            MoveForward();
        }
    }

    private void MoveForward()
    {
        if (rigidbody.velocity.magnitude < 3.5f)
        {
            rigidbody.AddForce(Vector3.forward * speed * Time.deltaTime);
        }
    }

    public void StopBall()
    {
        rigidbody.isKinematic = true;
        speed = 0;
    }

    void CheckTouch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            move = true;
        }
    }
    
    
  
 
}
