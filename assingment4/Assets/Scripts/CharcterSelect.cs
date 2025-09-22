using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharcterSelect : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform spawnpoint;
    public string gameSceneName = "Sample Scene";

    public void SelectCat()
    {
        PlayerPrefs.SetString("PlayerType", "Cat"); // Saves choice as Cat
        SceneManager.LoadScene(2);
    }

    public void SelectDog()
    {
        PlayerPrefs.SetString("PlayerType", "Dog");
        SceneManager.LoadScene(2);
    }

}
