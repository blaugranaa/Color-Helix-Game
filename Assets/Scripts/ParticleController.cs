using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField]
    GameObject finishParticlePrefab;

    [SerializeField]
    GameObject explosionPrefab;

    [SerializeField]
    GameObject ball;

    [SerializeField]
    Color PColor;

    private ParticleSystem ps;

    private void Awake()
    {
        ps = explosionPrefab.GetComponent<ParticleSystem>();
    }

    public void InstantiateExplosion()
    {
        Instantiate(explosionPrefab, ball.transform.position, Quaternion.identity);
    }

    public void InstantiateFinishParticle()
    {
        Instantiate(finishParticlePrefab, ball.transform.position, Quaternion.identity);
    }

    public void SetParticleColor()
    {
        //var main = explosionPrefab.gameObject.GetComponent<ParticleSystem>().main;
        //main.startColor = PColor;
    }

    
    
}
