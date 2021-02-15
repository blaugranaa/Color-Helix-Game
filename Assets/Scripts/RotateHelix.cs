using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHelix : MonoBehaviour
{
    bool isRotating = true;

    private float rotSpeed = 5;
   
    void Update()
    {
        OnMouseDrag();
    }

    private void OnMouseDrag()
    {
        if(isRotating)
        {
            Rotate();
        }      
    }

    private void Rotate()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed /** Time.deltaTime*/* Mathf.Deg2Rad;
        transform.RotateAround(Vector3.forward, -rotX);
    }

    public void GameOver()
    {
        isRotating = false;
    }
}
