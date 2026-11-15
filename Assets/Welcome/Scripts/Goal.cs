using UnityEngine;

public class Goal : MonoBehaviour
{
    // Type "Player1" for the right goal, or "Player2" for the left goal
    public string scorerID;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Checks if the object entering the goal is the Ball
        if (other.GetComponent<Ball>() != null)
        {
            GameManager.instance.AddScore(scorerID);

            // Reset ball to center
            other.transform.position = Vector2.zero;
        }
    }
}
