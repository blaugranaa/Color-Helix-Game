using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private BallMove ballMove;
    public BallMove BallMove { get { return (ballMove == null) ? ballMove = GetComponent<BallMove>() : ballMove; } }

    public static GameManager instance;

    public bool isStarted;

    [SerializeField] GameObject restartButton;
    public void Awake()
    {
        Singleton();
        restartButton = GetComponent<GameObject>();
    }

    void Singleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }

   public void FinishGame()
   {
        FindObjectOfType<RotateHelix>().GameOver();
        FindObjectOfType<BallMove>().StopBall();
   }

    public void Fail()
    {
        FindObjectOfType<BallMove>().StopBall();
        FindObjectOfType<RotateHelix>().GameOver();
        restartButton.SetActive(true);
    }
}
