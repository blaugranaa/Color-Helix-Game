using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallColor : MonoBehaviour
{
    BallMove ballMove;

    public Color currentColor;

    [SerializeField]
    GameObject splash;

    [SerializeField]


    private ParticleController particleController;
    //public ParticleController ParticleController { get { return (particleController == null) ? particleController = GetComponent<ParticleController>() : particleController; } }

    [SerializeField]
    Color orange, green, purple, blue;

    MeshRenderer meshRenderer;

    Color splashColor;

    int index;

    private void Awake()
    {
        ballMove = GetComponent<BallMove>();
        meshRenderer = GetComponent<MeshRenderer>();
        splashColor = splash.GetComponent<SpriteRenderer>().color;
    }
    void Start()
    {
        index = Random.Range(0, 4);
        ColorObj();
        currentColor = FindObjectOfType<BallColor>().GetComponent<MeshRenderer>().material.color;
    }
    private void Update()
    {
        splash.GetComponent<SpriteRenderer>().color = currentColor;
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
                    meshRenderer.material.color = orange;
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
            Destroy(other.gameObject);

        }
        else
        {
            Debug.Log("we could be the same");
            splash.SetActive(true);
            //GameManager.instance.FinishGame();
            //StartCoroutine(LoadSceneCo());
            //Destroy(gameObject.transform.parent.gameObject);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //Destroy(gameObject.transform.parent);
            GameManager.instance.Fail();
            FindObjectOfType<Button>().Finish();
            //GameObject.Find("Restart").SetActive(true);
        }
    }

    IEnumerator LoadSceneCo()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }     
}
