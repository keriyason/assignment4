using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TranstionRestartGame : MonoBehaviour
{
    public string charcterSelectSceneName = "Restart Game";

    public void RestartGame()
    {
        SceneManager.LoadScene(2);
    }
}
