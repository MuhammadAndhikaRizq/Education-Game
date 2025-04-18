using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Sources")]
    public AudioSource backgroundMusicSource;
    public AudioSource eventSoundSource;

    [Header("Audio Clips")]
    public AudioClip defaultSound;
    public AudioClip eventSound;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayDefaultSound();
    }

    public void PlayDefaultSound()
    {
        if (backgroundMusicSource != null && defaultSound != null)
        {
            backgroundMusicSource.clip = defaultSound;
            backgroundMusicSource.loop = true;
            backgroundMusicSource.Play();
        }
    }

    public void PlayEventSound()
    {
        if (eventSoundSource != null && eventSound != null)
        {
            eventSoundSource.PlayOneShot(eventSound);
        }
    }
}
