using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

public class Volume_Manager : MonoBehaviour
{

    public AudioSource audioSource;
    public static Volume_Manager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}