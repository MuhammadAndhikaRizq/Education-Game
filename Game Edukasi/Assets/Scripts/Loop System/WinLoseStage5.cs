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

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(powerTag))
        {
            poison.SetActive(false);
            StartCoroutine(ActiveWinUI());
            fire.SetActive(true);
            power.SetActive(false);
        }

        if (other.CompareTag(posionTag))
        {
            power.SetActive(false);
            StartCoroutine(ActiveLoseUI());
            explode.SetActive(true);
            poison.SetActive(false);
        }
    }

    IEnumerator ActiveWinUI()
    {
        yield return new WaitForSeconds(2);
        winUI.SetActive(true);
        fire.SetActive(false);
    }

    IEnumerator ActiveLoseUI()
    {
        yield return new WaitForSeconds(2);
        loseUI.SetActive(true);
        explode.SetActive(false);
    }

   
}