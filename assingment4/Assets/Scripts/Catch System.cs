using UnityEngine;
using TMPro;

public class CatchSystem : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;
    private int winScore = 10;

    public Player.PlayerType activePlayerType;

    private void Start()
    {
        string choice = PlayerPrefs.GetString("Player Type", "Cat");
        activePlayerType = choice == "Cat" ? Player.PlayerType.Cat : Player.PlayerType.Dog;

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
            // TODO: trigger win screen
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}