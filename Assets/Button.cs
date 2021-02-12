using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField]
    GameObject buttoon;
    void Start()
    {
        
    }

    public void Finish()
    {
        buttoon.SetActive(true);
    }
   
    void Update()
    {
        
    }
}
