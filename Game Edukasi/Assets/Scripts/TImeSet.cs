using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TImeSet : MonoBehaviour
{
    public TMP_Text timeText;
    public GameObject player;
    public GameObject sleepUI;
    public GameObject winUI;
    public GameObject loseUI;

    
    private int hours = 4, minutes = 50;
    private bool isRunning = false; 

    void OnEnable()
    {
        isRunning = true;
        StartCoroutine(TimeUpdater());
    }

    void OnDisable()
    {
        isRunning = false;
    }

    IEnumerator TimeUpdater()
    {
        while (isRunning)
        {
            yield return new WaitForSeconds(1f);
            minutes++;

            if (minutes >= 60)
            {
                minutes = 0;
                hours++;
            }

            UpdateTimeText();

            if (hours == 5 && minutes == 0)
            {
                DisplayCharacter();
            }
        }
    }

    void UpdateTimeText()
    {
        timeText.text = $"{hours:D2}:{minutes:D2}";
    }

    public void DisplayCharacter()
    {
        if (hours == 5 && minutes == 0)
        {
            
            loseUI.SetActive(true);
        }
        else
        {
            player.SetActive(true);
            sleepUI.SetActive(false);
            isRunning = false;
            StartCoroutine(DisplayWin());
        }
    }

    IEnumerator DisplayWin()
    {
        yield return new WaitForSeconds(2);
        winUI.SetActive(true);
    }

    public void ResetTimer()
    {
        hours = 4;
        minutes = 50;
        UpdateTimeText();

    }

}
