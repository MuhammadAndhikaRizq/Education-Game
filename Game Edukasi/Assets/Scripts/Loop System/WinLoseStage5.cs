using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseStage5 : MonoBehaviour
{
    [SerializeField] private GameObject winUI;
    [SerializeField] private GameObject loseUI;

    [SerializeField] private GameObject explode;
    [SerializeField] private GameObject fire;
    [SerializeField] private GameObject poison;
    [SerializeField] private GameObject power;
    [SerializeField] private string posionTag = "Poison";
    [SerializeField] private string powerTag = "Power";

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(powerTag))
        {
            winUI.SetActive(true);
            fire.SetActive(true);
            power.SetActive(false);
        }

        if (other.CompareTag(posionTag))
        {
            loseUI.SetActive(true);
            explode.SetActive(true);
            poison.SetActive(false);
        }
    }
}