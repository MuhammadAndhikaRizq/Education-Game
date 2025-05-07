using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public UI sceneSwitch;

    [Header("Audio Sources")]
    public AudioSource backgroundMusicSource;
    public AudioSource eventSoundSource;
    public AudioSource characterSelectedSource;
    public AudioSource andhikaSource;
    public AudioSource jasminSource;

    [Header("Audio Clips")]
    public AudioClip defaultSound;
    public AudioClip eventSound;
    public AudioClip characterSelectedSound;
    public AudioClip andhikaSound;
    public AudioClip jasminSound;

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

    public void PlayCharacterSelectedSound()
    {
        if (characterSelectedSource != null && characterSelectedSound != null)
        {
            characterSelectedSource.PlayOneShot(characterSelectedSound);
        }
    }

    public void PlayAndhikaSound(GameObject uiEnabled)
    {
        if (andhikaSource != null && andhikaSound != null)
        {
            andhikaSource.PlayOneShot(andhikaSound);
        }
        StartCoroutine(PlaySoundCharacter(uiEnabled));
    }

    public void PlayJasminSound(GameObject uiEnabled)
    {
        if (jasminSource != null && jasminSound != null)
        {
            jasminSource.PlayOneShot(jasminSound);
        }
        StartCoroutine(PlaySoundCharacter(uiEnabled));
    }

    IEnumerator PlaySoundCharacter(GameObject uiEnabled)
    {
        yield return new WaitForSeconds(2);
        sceneSwitch.SwitchTo(uiEnabled);
    }
}
