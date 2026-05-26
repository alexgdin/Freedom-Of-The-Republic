using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance { get; private set; }
    private AudioSource source;

    private void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip _sound)
    {
        source.PlayOneShot(_sound);
    }
}
