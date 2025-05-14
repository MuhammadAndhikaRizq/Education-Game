using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public UI sceneSwitch;
    private Coroutine npcCoroutine;
    #region Audio Sources
    [Header("Audio Sources")]
    public AudioSource backgroundMusicSource;
    public AudioSource eventSoundSource;
    public AudioSource winStage1SoundSource;
    public AudioSource loseStage1SoundSource;
    public AudioSource winMandiriSource;
    public AudioSource loseMandiriSource;
    public AudioSource winBeranisource;
    public AudioSource loseBeranisSource;
    public AudioSource endGameSource;

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
    public AudioSource boyTalkSource;
    public AudioSource girlTalkSource;

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
    public AudioClip endGameSound;
    
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
    public AudioClip boyTalk;
    public AudioClip girlTalk;

    [Header("Audio Clips Stage 6")]
    public AudioClip stage6Sound;

    [Header("Audio Clips Stage 7")]
    public AudioClip stage7Sound;

    [Header("Audio Clips Stage 8")]
    public AudioClip stage8Sound;

    [Header("Audio Clips Stage 9")]
    public AudioClip stage9Sound;
    public AudioClip stageBeraniwinSound;
    public AudioClip stageBeranioseSound;
    
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

        if (npcCoroutine == null) // hanya mulai jika belum berjalan
        {
            npcCoroutine = StartCoroutine(PlayNPC());
        }
    }

    public void StopStage2Sound()
    {
        if (stage2Source != null && stage2Source.isPlaying)
        {
            stage2Source.Stop();
        }

        if (npcCoroutine != null)
        {
            StopCoroutine(npcCoroutine);
            npcCoroutine = null;
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
            stage3Source.clip = stage3Sound;
            stage3Source.loop = false;  
            stage3Source.Play();
        }

        if (npcCoroutine == null) // hanya mulai jika belum berjalan
        {
            npcCoroutine = StartCoroutine(Stage3Dialogue());
        }
        
    }

    public void StopStage3Sound()
    {
        if (stage3Source != null && stage3Source.isPlaying)
        {
            stage3Source.Stop();
        }

        if (npcCoroutine != null)
        {
            StopCoroutine(npcCoroutine);
            npcCoroutine = null;
        }
    }

    public void PlayTeacherSound()
    {
        if (teacherSource != null && teacherSound != null)
        {
            teacherSource.clip = teacherSound;
            teacherSource.loop = false;  
            teacherSource.Play();
        }
    }

     public void StopTeacherSound()
    {
        if (teacherSource != null && npcSource.isPlaying)
        {
            teacherSource.Stop();
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
            stage4Source.clip = stage4Sound;
            stage4Source.loop = false;  
            stage4Source.Play();
        }
    }

    public void StopStage4Sound()
    {
        if (stage4Source != null && stage4Source.isPlaying)
        {
            stage4Source.Stop();
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
            stage5Source.clip = stage5Sound;
            stage5Source.loop = false;
            stage5Source.Play();
        }
    }

    public void StopStage5Sound()
    {
        if (stage5Source != null && stage5Source.isPlaying)
        {
            stage5Source.Stop();
        }
    }

    public void PlayWinStage5Sound()
    {
        if(stage5WinSource != null && stage5Win != null)
        {
            stage5WinSource.clip = stage5Win;
            stage5WinSource.loop = false;
            stage5WinSource.Play();
        }
    }

    public void StopWinStage5Sound()
    {
        if (stage5Source != null && stage5Source.isPlaying)
        {
            stage5Source.Stop();
        }
    }

    public void PlayLoseBeraniSound()
    {
        if(loseBeranisSource != null && stageBeranioseSound != null)
        {
            loseBeranisSource.clip = stageBeranioseSound;
            loseBeranisSource.loop = false;  
            loseBeranisSource.Play();
        }
    }

    public void StopLoseBeraniSound()
    {
        if (loseBeranisSource != null && loseBeranisSource.isPlaying)
        {
            loseBeranisSource.Stop();
        }
    }

    public void PlayBoyTalk()
    {
        if(boyTalkSource != null && boyTalk != null)
        {   
            boyTalkSource.clip = boyTalk;
            boyTalkSource.loop = false;
            boyTalkSource.Play();
        }
    }

    public void StopBoyTalk()
    {
        if (boyTalkSource != null && boyTalkSource.isPlaying)
        {
            boyTalkSource.Stop();
        }
    }

    public void PlayGirlTalk()
    {
        if(girlTalkSource != null && girlTalk != null)
        {   
            girlTalkSource.clip = girlTalk;
            girlTalkSource.loop = false;
            girlTalkSource.Play();
        }
    }

    public void StopGirlTalk()
    {
        if (girlTalkSource != null && girlTalkSource.isPlaying)
        {
            girlTalkSource.Stop();
        }
    }

    #endregion

    #region Stage 6-9
    public void PlayStage6Sound()
    {
        if(stage6Source != null && stage6Sound != null)
        {
            stage6Source.clip = stage6Sound;
            stage6Source.loop = false;
            stage6Source.Play();
        }
    }

    public void StopStage6Sound()
    {
        if (stage6Source != null && stage6Source.isPlaying)
        {
            stage6Source.Stop();
        }
    }

    public void PlayStage7Sound()
    {
        if(stage7Source != null && stage7Sound != null)
        {
            stage7Source.clip = stage7Sound;
            stage7Source.loop = false;
            stage7Source.Play();
        }
    }

    public void StopStage7Sound()
    {
        if (stage7Source != null && stage7Source.isPlaying)
        {
            stage7Source.Stop();
        }
    }

    public void PlayStage8Sound()
    {
        if(stage8Source != null && stage8Sound != null)
        {
            stage8Source.clip = stage8Sound;
            stage8Source.loop = false;
            stage8Source.Play();
        }
    }

    public void StopStage8Sound()
    {
        if (stage8Source != null && stage8Source.isPlaying)
        {
            stage8Source.Stop();
        }
    }

    public void PlayStage9Sound()
    {
        if(stage9Source != null && stage9Sound != null)
        {
            stage9Source.clip = stage9Sound;
            stage9Source.loop = false;
            stage9Source.Play();
        }
    }

    public void StopStage9Sound()
    {
        if (stage9Source != null && stage9Source.isPlaying)
        {
            stage9Source.Stop();
        }
    }

    #endregion

    #region Stage Mandiri
    public void PlayLoseStageMandiri()
    {
        if(loseMandiriSource != null && loseMandiriSound != null)
        {
            loseMandiriSource.clip = loseMandiriSound;
            loseMandiriSource.loop = false;
            loseMandiriSource.Play();
        }
    }

    public void StopLoseStageMandiri()
    {
        if (loseMandiriSource != null && loseMandiriSource.isPlaying)
        {
            loseMandiriSource.Stop();
        }
    }

    public void PlayWinStageMandiri()
    {
        if(winMandiriSource != null && winMandiriSound != null)
        {
            winMandiriSource.clip = winMandiriSound;
            winMandiriSource.loop = false;
            winMandiriSource.Play();
            
        }
    }

    public void StopWinStageMandiri()
    {
        if (winMandiriSource != null && winMandiriSource.isPlaying)
        {
            winMandiriSource.Stop();
        }
    }

    public void PlayEndGame()
    {
        if(endGameSource != null && endGameSound != null)
        {
            endGameSource.clip = endGameSound;
            endGameSource.loop = false;
            endGameSource.Play();
            
        }
    }

    public void StopEndGame()
    {
        if (endGameSource != null && endGameSource.isPlaying)
        {
            endGameSource.Stop();
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
