using System.Collections;
using UnityEngine;

public class ButtonActivetedCondition : MonoBehaviour
{
    public GameObject raiseHand;
    public GameObject winUI;
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

    IEnumerator ActiveWinUI()
    {
        yield return new WaitForSeconds(3);
        raiseHand.SetActive(false);
        winUI.SetActive(true);

    }
}