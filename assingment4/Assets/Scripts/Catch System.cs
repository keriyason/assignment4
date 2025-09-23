using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CatchSystem : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;
    private int winScore = 10;

    public Player.PlayerType activePlayerType;

    private void Start()
    {
        string choice = PlayerPrefs.GetString("Player Type", "Cat");

        if (choice == "Cat")
            activePlayerType = Player.PlayerType.Cat;
        else if (choice == "Dog")
            activePlayerType = Player.PlayerType.Dog;

            UpdateScoreText();

    }

    public void ObjectCaught(GameObject caughtObject)
    {
        string tag = caughtObject.tag;

        if (activePlayerType == Player.PlayerType.Cat)
        {
            if (tag == "Cat") score++;
            else if (tag == "Dog") score--;
        }
        else if (activePlayerType == Player.PlayerType.Dog)
        {
            if (tag == "Dog") score++;
            else if (tag == "Cat") score--;
        }

        Destroy(caughtObject);
        UpdateScoreText();

        if (score >= winScore)
        {
            Debug.Log(activePlayerType + " wins!");
            SceneManager.LoadScene(3);
            
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;

    }
}