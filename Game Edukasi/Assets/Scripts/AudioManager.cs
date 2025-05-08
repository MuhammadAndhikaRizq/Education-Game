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
    public AudioSource winStage1SoundSource;
    public AudioSource loseStage1SoundSource;

    [Header("Character Selection Audio Sources")]
    public AudioSource characterSelectedSource;
    public AudioSource andhikaSource;
    public AudioSource jasminSource;

    [Header("Stage 1 Audio Sources")]
    public AudioSource stage1Source;
    public AudioSource tutorial1Source;

    [Header("Audio Clips")]
    public AudioClip defaultSound;
    public AudioClip eventSound;
    public AudioClip characterSelectedSound;
    public AudioClip andhikaSound;
    public AudioClip jasminSound;
    
    [Header("Audio Clips Stage 1")]
    public AudioClip stageSound;
    public AudioClip tutorialSound;
    public AudioClip winStage1Sound;
    public AudioClip loseStage1Sound;
    

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

    public void PlayStage1Sound()
    {
        if (stage1Source != null && stageSound != null)
        {
            stage1Source.PlayOneShot(stageSound);
        }
    }

    public void PlayTutorialSound()
    {
        if (tutorial1Source != null && tutorialSound != null)
        {
            tutorial1Source.PlayOneShot(tutorialSound);
        }
    }

    public void PlayWinStage1Sound()
    {
        if (winStage1SoundSource != null && winStage1Sound != null)
        {
            winStage1SoundSource.PlayOneShot(winStage1Sound);
        }
    }

    public void PlayLoseStage1Sound()
    {
        if (loseStage1SoundSource != null && loseStage1Sound != null)
        {
            loseStage1SoundSource.PlayOneShot(loseStage1Sound);
        }
    }

    IEnumerator PlaySoundCharacter(GameObject uiEnabled)
    {
        yield return new WaitForSeconds(2);
        sceneSwitch.SwitchTo(uiEnabled);
        PlayStage1Sound();
        yield return new WaitForSeconds(3);
        PlayTutorialSound();
    }
}
