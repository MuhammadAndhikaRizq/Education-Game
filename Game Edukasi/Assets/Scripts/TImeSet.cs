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
    private float timer = 0f;
    private int hours = 4, minutes = 50;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 1f)
        {
            timer = 0f;
            minutes++;

            if(minutes >= 60f)
            {
                minutes = 0;
                hours++;
            }

            UpdateTimeNext();
        }
    }

    void UpdateTimeNext()
    {
        timeText.text = $"{hours:D2}:{minutes:D2}";
    }

    public void DisplayCharacter()
    {
        if(hours == 5 && minutes == 0)
        {
            sleepUI.SetActive(false);
            loseUI.SetActive(true);
        }  
        else{
            player.SetActive(true);
            sleepUI.SetActive(false);
            StartCoroutine(DisplayWin());
        }
    }

    IEnumerator DisplayWin()
    {
        yield return new WaitForSeconds(2);
        winUI.SetActive(true);
    }

}
