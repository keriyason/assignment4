using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform spawnPoint;
    public Sprite catSprite;
    public Sprite dogSprite;

    public enum PlayerType { Cat, Dog }
    public PlayerType playerType;
    private void Start()
    {
        string choice = PlayerPrefs.GetString("PlayerType", "Cat");
        Debug.Log("Selected character: " + choice);

        GameObject playerInstance = Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity);
        Player playerScript = playerInstance.GetComponent<Player>();

        if (choice == "Cat")
        {
            playerScript.playerType = Player.PlayerType.Cat;
            playerInstance.GetComponent<SpriteRenderer>().sprite = catSprite;
            Debug.Log("Spawned Cat Player prefab");
        }
        else if (choice == "Dog")
        {
            playerScript.playerType = Player.PlayerType.Dog;
            playerInstance.GetComponent<SpriteRenderer>().sprite = dogSprite;
            Debug.Log("Spawned Dog Player prefab");
        }
        CatchSystem catchSystem = playerInstance.GetComponentInParent<CatchSystem>();
        if (catchSystem != null)
        {
            var scoreUI = GameObject.Find("ScoreText");
                if (scoreUI != null)
            {
                catchSystem.scoreText = scoreUI.GetComponent<TMPro.TMP_Text>();
            }
            else
            {
                Debug.LogError("ScoreText TMP object not found in scene!");
            }
             
        }

    }

  }
