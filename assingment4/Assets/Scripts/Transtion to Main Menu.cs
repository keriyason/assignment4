using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TranstiontoMainMenu : MonoBehaviour
{
    public string charcterSelectSceneName = "Main Menu";

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}

