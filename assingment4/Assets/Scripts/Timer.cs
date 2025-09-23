using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f; 
    public bool timerIsRunning = false;
    public TMP_Text timerText;
    public GameObject restartButton; // Reset Button
    public GameObject mainMenuButton; // Main Menu Button
    void Start()
    {
        timerIsRunning = true; // Start Coundown
        restartButton.SetActive(false); // Hide Reset Button on Start
        mainMenuButton.SetActive(false); // Hide Main Menu Button on Start
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime; // Counting Down
                DisplayTime(timeRemaining); // Updates the Timer Text
            }
            else
            {
                Debug.Log("Game Over");
                timeRemaining = 0;
                timerIsRunning=false;
                DisplayTime(timeRemaining);

                restartButton.SetActive(true); // Show Reset Button when timer ends
                mainMenuButton.SetActive(true); // Show Main Menu Button when timer ends
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
    public void RestartGame()
    {
        Debug.Log("Restart button clicked!");
        SceneManager.LoadScene("Sample Scene");
    }
    public void GotoMainMenu()
    {
        Debug.Log("Main Menu button clicked!");
        SceneManager.LoadScene("Starting Screen + Carcter Select");
    }
}
