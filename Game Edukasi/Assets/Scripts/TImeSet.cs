using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TImeSet : MonoBehaviour
{
    public TMP_Text timeText;
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
}
