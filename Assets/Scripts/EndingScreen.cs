using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingScreen : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        // Get the score from the GameManager
        int score = GameManager.instance.GetScore();

        // Set the score text
        scoreText.text = "Score: " + score.ToString();
    }

    // Function to return to the main menu
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}