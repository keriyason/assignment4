using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public bool timerIsRunning = false;

    public TMP_Text timerText;
    void Start()
    {
        timerIsRunning = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime; // Counting Down
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Game Over");
                timeRemaining = 0;
                timerIsRunning=false;
            }
        }
        
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
