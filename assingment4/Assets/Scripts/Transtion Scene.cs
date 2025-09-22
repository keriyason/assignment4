using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TranstionScene : MonoBehaviour
{
    public string charcterSelectSceneName = "Charcter Select";

    public void GoToCharcterSelect()
    {
        SceneManager.LoadScene(1);
    }
}
