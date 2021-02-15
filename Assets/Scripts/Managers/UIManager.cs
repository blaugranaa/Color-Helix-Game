using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{  
   public void RestartGame()
   {
        //SceneManager.GetActiveScene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("presseddd");
   }
}
