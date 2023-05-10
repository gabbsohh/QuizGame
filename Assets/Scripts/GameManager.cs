using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [System.Serializable]
    public class QuizQuestion
    {
        public string question;
        public string[] answers;
        public int correctAnswerIndex;
    }

    // Variables to keep track of score and current question
    public int score = 0;
    private int currentQuestionIndex = 0;
    public List<QuizQuestion> questions;

    // Function to add points for a correct answer and load the next question
    public void RightAnswer()
    {
        // Add points for correct answer
        score++;

        // Check if this was the last question
        if (currentQuestionIndex == questions.Count - 1)
        {
            // Load the ending scene
            SceneManager.LoadScene("EndScene");
        }
        else
        {
            // Load the next question scene
            currentQuestionIndex++;
            SceneManager.LoadScene("Question" + (currentQuestionIndex + 1));
        }
    }

    // Function to get the current score
    public int GetScore()
    {
        return score;
    }

    // Function to reset the score and current question index
    public void ResetGame()
    {
        score = 0;
        currentQuestionIndex = 0;
    }
}





