﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("aloo");
        FindObjectOfType<BallMove>().StopBall();
    }
}
