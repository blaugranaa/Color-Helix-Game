using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    
    void Awake()
    {
        Singleton();
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

    public AudioClip jump;
    public AudioClip gold;
    public AudioClip gameOver;
    public AudioClip jumpBoost;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void JumpSound()
    {
        audioSource.clip = jump;
        audioSource.Play();
    }

    public void GoldSound()
    {
        audioSource.clip = gold;
        audioSource.Play();
    }

    public void FailSound()
    {
        audioSource.clip = gameOver;
        audioSource.Play();
    }

    public void JumpBoostSound()
    {
        audioSource.clip = jumpBoost;
        audioSource.Play();
    }
}
