using System.Collections;
using UnityEngine;

public class ButtonActivetedCondition : MonoBehaviour
{
    public GameObject raiseHand;
    public GameObject raiseHandStage4;
    public GameObject winUIStage3;
    public GameObject winUIStage4;
    public SpriteRenderer spriteRenderer;

    public Transform target;
    public Transform targetStage4;
    [Space]
    [Header("Stage 4")]
    public GameObject winUIStage5;
    public GameObject spriteStage4;
    public float speed = 5;

    private Vector3 startPositionStage3;
    private Vector3 startPositionStage4;

    public void Start()
    {
        startPositionStage3 = raiseHand.transform.position;
        startPositionStage4 = raiseHandStage4.transform.position;
    }

    public void ButtonActiveWin(GameObject gameObject)
    {
        if(spriteRenderer.sprite.name == "1")
        {
            AudioManager.Instance.PlayBoyWinSound();
        }else{
            AudioManager.Instance.PlayGirlWinSound();
        }

        StartCoroutine(NextStage(gameObject));
    }

    public void ButtonActiveLose(GameObject gameObject)
    {
        if(spriteRenderer.sprite.name == "1")
        {
            AudioManager.Instance.PlayBoyLoseSound();
        }else{
            AudioManager.Instance.PlayGirlLoseSound();
        }
        
        StartCoroutine(NextStage(gameObject));
    }

    public void ButtonActiveLoseStage3(GameObject gameObject)
    {   
        StartCoroutine(NextStage(gameObject));
    }

    IEnumerator NextStage(GameObject gameObject)
    {
        yield return new WaitForSeconds(2);
        if(gameObject.CompareTag("Win"))
        {
            AudioManager.Instance.PlayWinStage1Sound();
            AudioManager.Instance.PlayEventSound();
        }else{
            AudioManager.Instance.PlayLoseStage1Sound();
        }
        gameObject.SetActive(true);

    }
    public void ButtonActiveLoseStage4(GameObject gameObject)
    {
        gameObject.SetActive(true);
        spriteStage4.SetActive(false);
    }

    public void BuutonRaiseHand(GameObject stage)
    {
        bool isBoy = spriteRenderer.sprite.name == "1";
        // string currentStage = stage;

        if (stage.name == "Stage_3")
        {
            if (isBoy)
                AudioManager.Instance.PlayBoyWinStage3();
            else
                AudioManager.Instance.PlayGirlWinStage3();

            
            raiseHand.transform.localPosition = Vector3.Lerp(raiseHand.transform.position, target.position, Time.deltaTime * speed);
            StartCoroutine(ActiveWinUI3());
            
        }
        else if (stage.name == "Stage_4")
        {
            if (isBoy)
                AudioManager.Instance.PlayBoyAsk();
            else
                AudioManager.Instance.PlayGirlAsk();
            
        
            raiseHandStage4.transform.localPosition = Vector3.Lerp(raiseHand.transform.position, targetStage4.position, Time.deltaTime * speed);


            StartCoroutine(ActiveWinUI4());
        }
        
    }

    public IEnumerator ActiveWinUI3()
    {
        yield return new WaitForSeconds(1);
        AudioManager.Instance.PlayEventSound();
        AudioManager.Instance.PlayWinStage1Sound();
        raiseHand.SetActive(false);
        winUIStage3.SetActive(true);

    }

    public IEnumerator ActiveWinUI4()
    {
        yield return new WaitForSeconds(1);
        AudioManager.Instance.PlayEventSound();
        AudioManager.Instance.PlayWinStage1Sound();
        raiseHandStage4.SetActive(false);
        winUIStage4.SetActive(true);

    }

    public void ActivateWinUI5()
    {
        spriteStage4.SetActive(false);
        winUIStage5.SetActive(true);
    }

    public void ResetObject()
    {
        raiseHand.transform.position = startPositionStage3;
        raiseHandStage4.transform.position = startPositionStage4;
    }
}