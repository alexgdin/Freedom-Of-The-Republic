using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterManager : MonoBehaviour
{
    public int letterCount = 0;
    public static LetterManager Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            letterCount = PlayerPrefs.GetInt("letterCount", 0);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
