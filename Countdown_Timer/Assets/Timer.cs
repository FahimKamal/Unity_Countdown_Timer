using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeValue = 90f;
    public TextMeshProUGUI timerText;

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);
    }
    
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        /// This line is needed only when you want to display the time in minutes and seconds
        timeToDisplay += 1;
        /// This line is needed only when you want to display the time in minutes and seconds
        
        float hours = Mathf.FloorToInt(timeToDisplay / 3600);
        timeToDisplay -= hours * 3600;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        timeToDisplay -= minutes * 60;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        // float milliseconds = Mathf.FloorToInt((timeToDisplay * 100) % 100);
        // timerText.text = $"{hours:00}:{minutes:00}:{seconds:00}:{milliseconds:000}";
        timerText.text = $"{hours:00}:{minutes:00}:{seconds:00}";
    }
}
