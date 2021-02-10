using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHelix : MonoBehaviour
{
    private float rotSpeed = 20;

    void Start()
    {
        
    }

   
    void Update()
    {
        OnMouseDrag();
        //float rotate = Input.GetAxis("Mouse X");

        //Vector3 vector3 = new Vector3(0f, 0f, rotate * speedRotate);
        //transform.Rotate(vector3);
    }

    private void OnMouseDrag()
    {
        Rotate();
    }

    private void Rotate()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed /** Time.deltaTime*/* Mathf.Deg2Rad;
        transform.RotateAround(Vector3.forward, -rotX);

    }
}
