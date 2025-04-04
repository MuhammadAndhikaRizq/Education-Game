using System.Collections;
using UnityEngine;

public class ButtonActivetedCondition : MonoBehaviour
{
    public GameObject raiseHand;
    public GameObject winUIStage3;
    public Transform target;
    [Space]
    [Header("Stage 4")]
    public GameObject winUIStage4;
    public GameObject spriteStage4;
    public float speed = 5;


    public void ButtonActiveWin(GameObject gameObject)
    {
        AudioManager.Instance.PlayEventSound();
        gameObject.SetActive(true);
    }

    public void ButtonActiveLose(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public void ButtonActiveLoseStage4(GameObject gameObject)
    {
        gameObject.SetActive(true);
        spriteStage4.SetActive(false);
    }

    public void BuutonRaiseHand()
    {
        raiseHand.transform.localPosition = Vector3.Lerp(raiseHand.transform.position, target.position, Time.deltaTime * speed);
        StartCoroutine(ActiveWinUI());
    }

    public IEnumerator ActiveWinUI()
    {
        yield return new WaitForSeconds(1);
        AudioManager.Instance.PlayEventSound();
        raiseHand.SetActive(false);
        winUIStage3.SetActive(true);

    }

    public void ActivateWinUI4()
    {
        spriteStage4.SetActive(false);
        winUIStage4.SetActive(true);
    }
}