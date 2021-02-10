using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColor : MonoBehaviour
{
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
        index = Random.Range(0,4);
        ColorObj();
    }

   
    void Update()
    {
        
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

}
