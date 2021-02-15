using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var scene = SceneManager.GetActiveScene().buildIndex;
        if(scene == 2)
        {
            GameManager.instance.FinishGame();
            FindObjectOfType<ParticleController>().InstantiateFinishParticle();
            Debug.Log("finn");
        }
        else
        {
            GameManager.instance.FinishGame();
            FindObjectOfType<ParticleController>().InstantiateFinishParticle();
            StartCoroutine(NextSceneCo());
        } 
    }

    IEnumerator NextSceneCo()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
