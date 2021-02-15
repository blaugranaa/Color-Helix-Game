using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slider : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject finishLine;

    
    public UnityEngine.UI.Slider slider;

    float distanceMax;
    void Start()
    {
        distanceMax = Vector3.Distance(player.transform.position, finishLine.transform.position);
    }

    void Update()
    {
        float distanceMin = Vector3.Distance(player.transform.position, finishLine.transform.position);

        float sliderValue = 1 - (distanceMin / distanceMax);

        slider.value = sliderValue;    
    }
}
