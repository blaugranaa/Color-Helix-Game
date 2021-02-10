using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{

    [SerializeField]
    GameObject explosionPrefab;

    [SerializeField]
    GameObject ball;


    public void InstantiateExplosion()
    {
        Instantiate(explosionPrefab, ball.transform.position, Quaternion.identity);
    }
}
