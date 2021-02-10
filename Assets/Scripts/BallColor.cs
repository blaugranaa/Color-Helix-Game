using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallColor : MonoBehaviour
{
    [SerializeField]
    GameObject splash;
    private ParticleController particleController;
    //public ParticleController ParticleController { get { return (particleController == null) ? particleController = GetComponent<ParticleController>() : particleController; } }

    [SerializeField]
    Color purple, green, pink, blue;

    MeshRenderer meshRenderer;

    int index;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    void Start()
    {
        index = Random.Range(0, 4);
        ColorObj();
    }

    public void ColorObj()
    {
        switch (index)
        {
            case 0:
                {
                    meshRenderer.material.color = purple;
                    break;
                }
            case 1:
                {
                    meshRenderer.material.color = blue;
                    break;
                }
            case 2:
                {
                    meshRenderer.material.color = pink;
                    break;
                }
            case 3:
                {
                    meshRenderer.material.color = green;
                    break;
                }

            default:
                break;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        var color = other.gameObject.GetComponent<MeshRenderer>().material.color;
        if (color == meshRenderer.material.color)
        {
            Debug.Log("saame");
            FindObjectOfType<ParticleController>().InstantiateExplosion();
           // particleController.InstantiateExplosion();
            Destroy(other.gameObject);
        }
        else
        {
            FindObjectOfType<RotateHelix>().GameOver();
            Debug.Log("we could be the same");
            splash.SetActive(true);

            int indexscene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(indexscene);
        }
    }
}
