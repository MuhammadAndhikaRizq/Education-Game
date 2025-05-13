using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public UI sceneSwitch;

    #region Audio Sources
    [Header("Audio Sources")]
    public AudioSource backgroundMusicSource;
    public AudioSource eventSoundSource;
    public AudioSource winStage1SoundSource;
    public AudioSource loseStage1SoundSource;
    public AudioSource winMandiriSource;
    public AudioSource loseMandiriSource;

    [Header("Character Selection Audio Sources")]
    public AudioSource characterSelectedSource;
    public AudioSource andhikaSource;
    public AudioSource jasminSource;

    [Header("Stage 1 Audio Sources")]
    public AudioSource stage1Source;
    [Header("Stage 2 Audio Sources")]
    public AudioSource stage2Source;
    public AudioSource npcSource;
    public AudioSource boyWinSource;
    public AudioSource girlWinSource;
    public AudioSource boyLoseSource;
    public AudioSource girlLoseSource;

    [Header("Stage 3 Audio Sources")]
    public AudioSource stage3Source;
    public AudioSource teacherSource;
    public AudioSource boyWinStage3Source;
    public AudioSource girlWinStage3Source;

    [Header("Stage 4 Audio Sources")]
    public AudioSource stage4Source;
    public AudioSource boyAskSource;
    public AudioSource girlAskSource;
    
    [Header("Stage 5 Audio Sources")]
    public AudioSource stage5Source;
    public AudioSource stage5WinSource;

    [Header("Stage 6 Audio Sources")]
    public AudioSource stage6Source;

    [Header("Stage 7 Audio Sources")]
    public AudioSource stage7Source;

    [Header("Stage 8 Audio Sources")]
    public AudioSource stage8Source;

    [Header("Stage 9 Audio Sources")]
    public AudioSource stage9Source;

    #endregion

    #region Audio Clips
    [Header("Audio Clips")]
    public AudioClip defaultSound;
    public AudioClip eventSound;
    public AudioClip characterSelectedSound;
    public AudioClip andhikaSound;
    public AudioClip jasminSound;
    public AudioClip winMandiriSound;
    public AudioClip loseMandiriSound;
    
    [Header("Audio Clips Stage 1")]
    public AudioClip stageSound;
    public AudioClip winStage1Sound;
    public AudioClip loseStage1Sound;

    [Header("Audio Clips Stage 2")]
    public AudioClip stage2Sound;
    public AudioClip npcSound;
    public AudioClip boyWinSound;
    public AudioClip girlWinSound;
    public AudioClip boyLoseSound;
    public AudioClip girlLoseSound;

    [Header("Audio clips Stage 3")]
    public AudioClip stage3Sound;
    public AudioClip teacherSound;
    public AudioClip boyWinStage3Sound;
    public AudioClip girlWinStage3Sound;

    [Header("Audio clips Stage 4")]
    public AudioClip stage4Sound;
    public AudioClip boyAsk;
    public AudioClip girlAsk;

    [Header("Audio Clips Stage 5")]
    public AudioClip stage5Sound;
    public AudioClip stage5Win;

    [Header("Audio Clips Stage 6")]
    public AudioClip stage6Sound;

    [Header("Audio Clips Stage 7")]
    public AudioClip stage7Sound;

    [Header("Audio Clips Stage 8")]
    public AudioClip stage8Sound;

    [Header("Audio Clips Stage 9")]
    public AudioClip stage9Sound;
    
    #endregion

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

    #region Warmup Audio
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
    #endregion

    #region Stage 1
    public void PlayStage1Sound()
    {

        if (stage1Source != null && stageSound != null)
        {
            stage1Source.clip = stageSound;
            stage1Source.loop = false;  
            stage1Source.Play();
        }
    }

    public void StopStage1Sound()
    {
        if (stage1Source != null && stage1Source.isPlaying)
        {
            stage1Source.Stop();
            // isStoppedManually = true;
        }
    }

    public void PlayWinStage1Sound()
    {
        if (winStage1SoundSource != null && winStage1Sound != null)
        {
            winStage1SoundSource.clip = winStage1Sound;
            winStage1SoundSource.loop = false;  
            winStage1SoundSource.Play();
        }
    }

    public void StopWinStage1Sound()
    {
        if (winStage1SoundSource != null && winStage1SoundSource.isPlaying)
        {
            winStage1SoundSource.Stop();
        }
    }

    public void PlayLoseStage1Sound()
    {
        if (loseStage1SoundSource != null && loseStage1Sound != null)
        {
            loseStage1SoundSource.clip = loseStage1Sound;
            loseStage1SoundSource.loop = false;  
            loseStage1SoundSource.Play();
        }
    }

    public void StopLoseStage1Sound()
    {
        if (loseStage1SoundSource != null && loseStage1SoundSource.isPlaying)
        {
            winStage1SoundSource.Stop();
        }
    }
    #endregion

    #region Stage 2
    public void PlayStage2Sound()
    {
        if(stage2Source != null && stage2Sound != null)
        {
            stage2Source.clip = stage2Sound;
            stage2Source.loop = false;  
            stage2Source.Play();
        }

        StartCoroutine(PlayNPC());
    }

    public void StopStage2Sound()
    {
        if (stage2Source != null && stage2Source.isPlaying)
        {
            stage2Source.Stop();
        }
    }

    public void PlayNPCSound()
    {
        if (npcSource != null && npcSound != null)
        {
            npcSource.clip = npcSound;
            npcSource.loop = false;  
            npcSource.Play();
        }
    }

    public void StopNPCSound()
    {
        if (npcSource != null && npcSource.isPlaying)
        {
            npcSource.Stop();
        }
    }


    public void PlayBoyWinSound()
    {
        if (boyWinSource != null && boyWinSound != null)
        {
            boyWinSource.PlayOneShot(boyWinSound);
        }
    }

    public void PlayGirlWinSound()
    {
        if (girlWinSource != null && girlWinSound != null)
        {
            girlWinSource.PlayOneShot(girlWinSound);
        }
    }

    public void PlayBoyLoseSound()
    {
        if (boyLoseSource != null && boyLoseSound != null)
        {
            boyLoseSource.PlayOneShot(boyLoseSound);
        }
    }

    public void PlayGirlLoseSound()
    {
        if(girlLoseSource != null && girlLoseSound != null)
        {
            girlLoseSource.PlayOneShot(girlLoseSound);
        }
    
    }
    #endregion

    #region Stage 3
    public void PlayStage3Sound()
    {
        if (stage3Source != null && stage3Sound != null)
        {
            stage3Source.PlayOneShot(stage3Sound);
        }

        StartCoroutine(Stage3Dialogue());
    }

    public void PlayTeacherSound()
    {
        if (teacherSource != null && teacherSound != null)
        {
            teacherSource.PlayOneShot(teacherSound);
        }
    }

    public void PlayBoyWinStage3()
    {
        if (boyWinStage3Source != null && boyWinStage3Sound != null)
        {
            boyWinStage3Source.PlayOneShot(boyWinStage3Sound);
        }
    }

    public void PlayGirlWinStage3()
    {
        if (girlWinStage3Source != null && girlWinStage3Sound != null)
        {
            girlWinStage3Source.PlayOneShot(girlWinStage3Sound);
        }
    }

    #endregion

    #region Stage 4

    public void PlayStage4Sound()
    {
        if(stage4Source != null && stage4Sound != null)
        {
            stage4Source.PlayOneShot(stage4Sound);
        }
    }

    public void PlayBoyAsk()
    {
        if(boyAskSource != null && boyAsk != null)
        {
            boyAskSource.PlayOneShot(boyAsk);
        }
    }

    public void PlayGirlAsk()
    {
        if(girlAskSource != null && girlAsk != null)
        {
            girlAskSource.PlayOneShot(girlAsk);
        }
    }

    #endregion

    #region Stage 5

    public void PlayStage5Sound()
    {
        if(stage5Source != null && stage5Sound != null)
        {
            stage5Source.PlayOneShot(stage5Sound);
        }
    }

    public void PlayWinStage5Sound()
    {
        if(stage5WinSource != null && stage5Win != null)
        {
            stage5WinSource.PlayOneShot(stage5Win);
        }
    }

    #endregion

    #region Stage Mandiri
    public void PlayLoseStageMandiri()
    {
        if(loseMandiriSource != null && loseMandiriSound != null)
        {
            loseMandiriSource.PlayOneShot(loseMandiriSound);
        }
    }

    public void PlayWinStageMandiri()
    {
        if(winMandiriSource != null && winMandiriSound != null)
        {
            winMandiriSource.PlayOneShot(winMandiriSound);
        }
    }

    #endregion
    IEnumerator Stage3Dialogue()
    {
        yield return new WaitForSeconds(6);
        PlayTeacherSound();
    }
    IEnumerator PlayNPC()
    {
        yield return new WaitForSeconds(4);
        PlayNPCSound();
    }

    IEnumerator PlaySoundCharacter(GameObject uiEnabled)
    {
        yield return new WaitForSeconds(2);
        sceneSwitch.SwitchTo(uiEnabled);
        PlayStage1Sound();
    }
}
