using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBump : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().material.color = gameObject.GetComponent<MeshRenderer>().material.color;
        FindObjectOfType<BallColor>().currentColor = gameObject.GetComponent<MeshRenderer>().material.color;
    }
}
