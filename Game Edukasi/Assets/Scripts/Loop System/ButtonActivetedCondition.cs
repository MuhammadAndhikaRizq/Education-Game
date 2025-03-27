using UnityEngine;

public class ButtonActivetedCondition : MonoBehaviour
{
    public GameObject raiseHand;
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
        raiseHand.transform.localPosition = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
    }
}