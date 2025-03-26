using UnityEngine;

public class ButtonActivetedCondition : MonoBehaviour
{
    public void ButtonActiveWin(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public void ButtonActiveLose(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
}