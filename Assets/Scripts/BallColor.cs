using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallColor : MonoBehaviour
{
    BallMove ballMove;

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
        ballMove = GetComponent<BallMove>();
        meshRenderer = GetComponent<MeshRenderer>();
    }
    void Start()
    {
        
        index = Random.Range(0, 4);
        ColorObj();
    }

    public void ColorObj()
    {
        var splashColor = splash.GetComponent<SpriteRenderer>().material.color;
        switch (index)
        {
            case 0:
                {
                    meshRenderer.material.color = purple;
                    splashColor = purple;
                    break;
                }
            case 1:
                {
                    meshRenderer.material.color = blue;
                    splashColor = blue;
                    break;
                }
            case 2:
                {
                    meshRenderer.material.color = pink;
                    splashColor = pink;
                    break;
                }
            case 3:
                {
                    meshRenderer.material.color = green;
                    splashColor = green;
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
            ballMove.StopBall();


            //int indexscene = SceneManager.GetActiveScene().buildIndex;
            //SceneManager.LoadScene(indexscene);
        }
    }
}
