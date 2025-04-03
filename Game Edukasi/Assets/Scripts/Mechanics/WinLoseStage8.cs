using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseStage8 : MonoBehaviour
{
    public List<GameObject> insideBag;
    public GameObject winUI;

    public void Update()
    {
        WindCondition();
    }

    public void WindCondition()
    {
        if (insideBag.Count == 7)
        {
            AudioManager.Instance.PlayEventSound();
            winUI.SetActive(true);
        }
    }
}