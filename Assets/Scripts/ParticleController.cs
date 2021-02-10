using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{

    [SerializeField]
    GameObject explosionPrefab;


    public void InstantiateExplosion()
    {
        Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
    }
}
