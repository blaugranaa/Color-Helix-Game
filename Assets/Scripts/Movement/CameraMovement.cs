using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    GameObject player = default;
    private Vector3 _offset;

    public void Start()
    {
        _offset = transform.position - player.transform.position;
    }

    public void Update()
    {
        transform.position = player.transform.position + _offset;
    }
}
