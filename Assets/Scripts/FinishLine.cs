using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.FinishGame();
        FindObjectOfType<ParticleController>().InstantiateFinishParticle();
        StartCoroutine(NextSceneCo());
    }

    IEnumerator NextSceneCo()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
