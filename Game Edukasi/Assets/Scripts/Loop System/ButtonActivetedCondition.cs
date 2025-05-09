using System.Collections;
using UnityEngine;

public class ButtonActivetedCondition : MonoBehaviour
{
    public GameObject raiseHand;
    public GameObject winUIStage3;
    public SpriteRenderer spriteRenderer;

    public Transform target;
    [Space]
    [Header("Stage 4")]
    public GameObject winUIStage4;
    public GameObject spriteStage4;
    public float speed = 5;


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

    public void BuutonRaiseHand()
    {
        if(spriteRenderer.sprite.name == "1")
        {
            AudioManager.Instance.PlayBoyWinStage3();
        }else{
            AudioManager.Instance.PlayGirlWinStage3();
        }

        raiseHand.transform.localPosition = Vector3.Lerp(raiseHand.transform.position, target.position, Time.deltaTime * speed);
        StartCoroutine(ActiveWinUI());
    }

    public IEnumerator ActiveWinUI()
    {
        yield return new WaitForSeconds(1);
        AudioManager.Instance.PlayEventSound();
        AudioManager.Instance.PlayWinStage1Sound();
        raiseHand.SetActive(false);
        winUIStage3.SetActive(true);

    }

    public void ActivateWinUI4()
    {
        spriteStage4.SetActive(false);
        winUIStage4.SetActive(true);
    }
}