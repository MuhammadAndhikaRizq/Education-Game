using System.Collections;
using UnityEngine;

public class ButtonActivetedCondition : MonoBehaviour
{
    public GameObject raiseHand;
    public GameObject winUIStage3;
    [Space]
    [Header("Stage 4")]
    public GameObject winUIStage4;
    public GameObject spriteStage4;
    public Transform target;
    public float speed = 5;


    public void ButtonActiveWin(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public void ButtonActiveLose(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public void BuutonRaiseHand()
    {
        raiseHand.transform.localPosition = Vector3.Lerp(raiseHand.transform.position, target.position, Time.deltaTime * speed);
        StartCoroutine(ActiveWinUI());
    }

    public IEnumerator ActiveWinUI()
    {
        yield return new WaitForSeconds(1);
        raiseHand.SetActive(false);
        winUIStage3.SetActive(true);

    }

    public void ActivateWinUI4()
    {
        spriteStage4.SetActive(false);
        winUIStage4.SetActive(true);
    }
}