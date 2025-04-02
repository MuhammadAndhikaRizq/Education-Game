using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseStage7 : MonoBehaviour
{
    public List<GameObject> trashs;
    [SerializeField] private GameObject winUI;

    public void WinCondition()
    {
        trashs.RemoveAll(item => item == null);
        if (trashs.Count == 0)
        {
            winUI.SetActive(true);
        }
    }

   

}