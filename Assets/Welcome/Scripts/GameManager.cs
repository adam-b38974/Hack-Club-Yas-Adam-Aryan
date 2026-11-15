using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Scores")]
    private int player1Score = 0;
    private int player2Score = 0;

    [Header("UI References")]
    public Text player1Text;
    public Text player2Text;

    void Awake()
    {
        // Singleton pattern to easily access the GameManager from other scripts
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    // Call this method when a goal is scored
    public void AddScore(string scorerID)
    {
        if (scorerID == "Player1")
        {
            player1Score++;
            player1Text.text = player1Score.ToString();
        }
        else if (scorerID == "Player2")
        {
            player2Score++;
            player2Text.text = player2Score.ToString();
        }
    }
}
